using UnityEngine;

public class SelecatbleObjectStory : MonoBehaviour
{
    //Reshai
    public string Genie;
    public string DefaultRply;
    public string Name;
    Rply MyRply = new Rply();

    public struct Rply
    {
        public string GenieTalk;
        public string DefaultRplyByChar;
        public string Name;
    }

    private void Start()
    {
        MyRply.GenieTalk = Genie;
        MyRply.DefaultRplyByChar = DefaultRply;
        MyRply.Name = Name;
    }

    public Rply ReturnCurrentRply()
    {
        return MyRply;
    }
}
