namespace CalculadoraIMC
{
    public static class Calculadora
    {
        public static string CalcularIMC(double kg, double altura)
        {
            double resultado = kg / (altura * altura);

            if (resultado < 18.5)
            {
                return "Abaixo do peso";
            }
            if (resultado < 24.9)
            {
                return "Peso Normal";
            }
            if (resultado < 29.9)
            {
                return "Sobrepeso";
            }
            if (resultado < 34.9)
            {
                return "Obesidade Grau 1";
            }
            if (resultado < 39.9)
            {
                return "Obesidade Grau 2";
            }
            else
            {
                return "Obesidade Grau 3";
            }

        }
        // Para classes comuns, instancia objeto
        //Calculadora cal = new Calculadora;
        //calc.CalculadrIMC();

        //Para classes estaticas (static), não é necessario a instancia
        //Calculadora.CalcularIMC();

    }
}
