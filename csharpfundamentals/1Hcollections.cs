class Collection
{
    public void LearnList()
    {

        // Define list of 10 numbers.
        List<byte> EvenNumbers = new List<byte> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

        // stack and queue
        Stack<string> plates = new Stack<string>(); //LIFO
        plates.Push("plate1");
        plates.Push("plate2");
        plates.Push("plate3");
        plates.Pop();

        foreach (var item in plates)
        {
            System.Console.WriteLine(item);
        }




        Queue<string> plateKoLine = new Queue<string>(); //FIFO
        plateKoLine.Enqueue("plate1");
        plateKoLine.Enqueue("plate2");
        plateKoLine.Enqueue("plate3");
        plateKoLine.Dequeue();

        foreach (var value in plateKoLine)
        {
            System.Console.WriteLine(value);
        }




    }

    public void LearnDictionary()
    {

        Dictionary<string, string> countryCapitals = new();
        countryCapitals.Add("Nepal", "Kathmandu");
        countryCapitals.Add("India", "Delhi");
        countryCapitals.Add("China", "Beijing");
        countryCapitals.Add("Bhutan", "Thimpu");
        foreach (var item in countryCapitals)
        {
            System.Console.WriteLine($"{item.Key} -> {item.Value}");
        }
        Dictionary<string, int> countryPopulation = new();

        countryPopulation.Add("Nepal", 43343438);
        countryPopulation.Add("India", 4888848);
        countryPopulation.Add("USA", 8383838);
        countryPopulation.Add("Japan", 89494949);
        System.Console.WriteLine("Country\t\t\t" + "Population");
        System.Console.WriteLine("................................");
        foreach (var items in countryPopulation)
        {
            System.Console.WriteLine($"{items.Key}\t\t\t {items.Value}");
        }

    }




}

