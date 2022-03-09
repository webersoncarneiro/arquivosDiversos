namespace ConsoleApp1
{
    public class Conversao
    {

        public void ConvertValores()
        {
            int inteiro = 100;
            float real = 25.5f;

            //real = inteiro; // 100.0f
            //inteiro = (int)real;
            //string valorReal = real.ToString();
            //inteiro = int.Parse(valorReal);
            inteiro = Convert.ToInt32(real);

            Console.WriteLine(inteiro);
            Console.WriteLine(Convert.ToBoolean(1));
            //Console.WriteLine(valorReal);
        }
        
    }
}
