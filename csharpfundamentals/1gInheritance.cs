class Mansion : House
{


    public Mansion()
    {


    }



    public Mansion(short nf, short nr) : base(nf, nr)
    {

    }

    float swimmingPoolArea;
    float numberOfHelipad;
    void CallServant()
    {

        System.Console.WriteLine("Need to clean swimming pool ........");
    }

}


class palace: Mansion       //Multi-level inheritance
{

short NumberOfRoyalGuards;

}   