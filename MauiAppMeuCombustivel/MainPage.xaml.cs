namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                

                string message = "";

                if (etanol <= (gasolina * 0.7))
                {
                    message = "O etanol está compensando";

                }
                else {

                    message = "A gasolina está compensando.";
                }

                DisplayAlert("Calculado", message, "Ok");

            } catch(Exception ex)
            {
                DisplayAlert("Alerta!!", ex.Message, "Fechar");
            }

        } // Fecha método
    }// Fecha Class

}//Fech namespace
