using UnityEngine;

public class SelecatbleObjectStory : MonoBehaviour
{
    //Reshai
    public string Genie;
    public string DefaultRply;
    public int Ui;
    public string FirstOption;
    public string SecondOption;
    Rply MyRply = new Rply();

    public struct Rply
    {
        public string GenieTalk;
        public string MyDefaultRply;
        public int UI;
        public string MyFirstOption;
        public string MySecondOption;
    }

    private void Start()
    {
        MyRply.GenieTalk = Genie;
        MyRply.MyDefaultRply = DefaultRply;
        MyRply.UI = Ui;
        MyRply.MyFirstOption = FirstOption;
        MyRply.MySecondOption = SecondOption;
    }

    public Rply ReturnCurrentRply()
    {
        return MyRply;
    }
}
