using UnityEngine;

public class SelecatbleObjectStory : MonoBehaviour
{
    //Reshai
    public string Genie;
    public string DefaultRply;
    Rply MyRply = new Rply();

    public struct Rply
    {
        public string GenieTalk;
        public string DefaultRplyByChar;
    }

    private void Start()
    {
        MyRply.GenieTalk = Genie;
        MyRply.DefaultRplyByChar = DefaultRply;
    }

    public Rply ReturnCurrentRply()
    {
        return MyRply;
    }
}
