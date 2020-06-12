using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Criaturas : MonoBehaviour {

    public Counter cnt;

    public Status sta;
    public Slider sl;

    [SerializeField]
    float vidaAtual;

    [SerializeField]
    GameObject alvo;
    Criaturas _alvo;

    [Range(0, 0.5f)]
    public float limitador;

    [SerializeField]
    float timer;

    public Animator anim;

    Rigidbody rgb;

	void Start ()
    {
        sta.Forca = Random.Range(4, 9);
        sta.Destreza = Random.Range(4, 9);
        sta.Agilidade = Random.Range(4, 9);

        vidaAtual = sta.Pontos_Vida = Random.Range(5, 11) * 3;
        sta.Armadura = Random.Range(1, 6);
        sta.Esquiva = Random.Range(1, 6);

        anim.speed = sta.Agilidade / 4;

        rgb = GetComponent<Rigidbody>();
    }

	void Update ()
    {
        if (alvo == null)
        {
            //alvo = tag == "Inimigos" ? GameObject.FindGameObjectWithTag("Aliados") : GameObject.FindGameObjectWithTag("Inimigos");
            if (tag == "Aliados")
                alvo = cnt.g2[Random.Range(0,cnt.g2.Count)];
            else
                alvo = cnt.g1[Random.Range(0, cnt.g1.Count)];

            if (alvo != null)
                _alvo = alvo.GetComponent<Criaturas>();
            else
                return;
        }

        float distacia = Vector3.Distance(transform.position, alvo.transform.position);

        if (distacia > 1.5f)
        {
            var speed = Time.deltaTime * sta.Agilidade * limitador;
            transform.LookAt(alvo.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, alvo.transform.position, speed);
            rgb.velocity = Vector3.zero;
            rgb.angularVelocity = Vector3.zero;
            rgb.rotation = Quaternion.identity;
        }
        else
        {
            timer -= Time.deltaTime * sta.Agilidade;
            if (timer <= 0)
            {
                anim.SetBool("Swing", true);
                DoDamage();
                timer = 10;
            }
        }
	}

    void DoDamage()
    {
        if (Random.Range(1, 5) + sta.Destreza > _alvo.sta.Esquiva)
        {
            var dano = Random.Range(1, 5) + sta.Forca;
            if (dano > sta.Armadura)
            {
                dano -= sta.Armadura;
                _alvo.Ponto_de_Vida(-dano, gameObject);
            }
        }
    }

    public void Ponto_de_Vida(int amount, GameObject gm)
    {
        if (amount < 0 && gm != alvo)
        {
            alvo = gm;
            _alvo = alvo.GetComponent<Criaturas>();
        }

        vidaAtual += amount;
        vidaAtual = Mathf.Clamp(vidaAtual, 0, sta.Pontos_Vida);
        sl.value = vidaAtual / sta.Pontos_Vida;

        if (vidaAtual == 0) Destroy(gameObject);
    }


}
