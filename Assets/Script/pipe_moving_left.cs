using UnityEngine;



public class pipe_moving_left : MonoBehaviour{

public GameObject top_pipe;
public GameObject buttom_pipe;

private SpriteRenderer top_render;
private SpriteRenderer buttom_render;

private float easy = 8f;

public float speed = 1f;



void Awake()
    {   
        // int random_pos = Random.Range(-23,0);
        // transform.position = new Vector3((float)random_pos,0f,0f); //random position to visualize the height difference(test only)
        transform.position = new Vector3(10f, 0f, 0f);
        top_pipe.transform.position = new Vector3(10f, 4f, 0f);
        buttom_pipe.transform.position = new Vector3(10f, -4f, 0f);
    }
void OnEnable()
    {
        float random_top = Random.Range(2.5f * easy, 100f * easy);

        float random_buttom = Random.Range(2.5f * easy, 100f * easy);

        Debug.Log($"random_top = {random_top}\n random_buttom = {random_buttom}");

        random_pipe_height(random_top, random_buttom);
    }
        

private void random_pipe_height(float top_cut, float buttom_cut)
    {
        top_render = top_pipe.GetComponent<SpriteRenderer>();

        Sprite top_sprite = top_render.sprite;
        Texture2D top_text = top_sprite.texture;
        Rect top_rect = top_sprite.rect;

        buttom_render = buttom_pipe.GetComponent<SpriteRenderer>();

        Sprite buttom_sprite = buttom_render.sprite;
        Texture2D buttom_text = buttom_sprite.texture;
        Rect buttom_rect = buttom_sprite.rect;

        Sprite newsp = Sprite.Create(
            top_text,
            new Rect(top_rect.x, top_rect.y, top_rect.width, top_rect.height - top_cut),
            new Vector2(0.5f, 0.5f),
            top_sprite.pixelsPerUnit

        );

        Sprite newsp2 = Sprite.Create(
            buttom_text,
            new Rect(top_rect.x, top_rect.y, top_rect.width, top_rect.height - buttom_cut),
            new Vector2(0.5f, 0.5f),
            buttom_sprite.pixelsPerUnit

        );

        top_render.sprite = newsp;
        buttom_render.sprite = newsp2;

        Destroy(top_pipe.GetComponent<PolygonCollider2D>());
        top_pipe.AddComponent<PolygonCollider2D>();

        Destroy(buttom_pipe.GetComponent<PolygonCollider2D>());
        buttom_pipe.AddComponent<PolygonCollider2D>();

    }
    
        
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x <= -15.8f){
            Destroy(gameObject);
        }
    }

}