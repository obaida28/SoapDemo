

public class SampleService : ISampleService
{
  public string Test(string s)
  {
    Console.WriteLine("Test Method Executed!");
    return "OBAIDA" + s + "OBAIDA";
  }

  public void XmlMethod(XElement xml)
  {
    Console.WriteLine(xml.ToString());
  }

  public MyCustomModel TestCustomModel(MyCustomModel MyCustomModel)
  {
    MyCustomModel.Id = 100;
    return MyCustomModel;
  }
  public int sum(int a , int b) {
    return a + b;
  }
}