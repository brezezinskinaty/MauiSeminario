namespace MauiSeminarioNovo;

public partial class DetalhesPage : ContentPage
{
    public DetalhesPage()
    {
        Title = "Sobre o projeto";

        Content = new VerticalStackLayout
        {
            Padding = 30,
            Spacing = 20,
            Children =
            {
                new Label
                {
                    Text = ".NET MAUI na prática",
                    FontSize = 30,
                    FontAttributes = FontAttributes.Bold
                },

                new Label
                {
                    Text = "Você navegou para uma segunda página!",
                    FontSize = 20
                },

                new Label
                {
                    Text = "Esta página demonstra a navegação entre páginas utilizando o Shell do .NET MAUI.",
                    FontSize = 17
                },

                new Label
                {
                    Text = "Tecnologias: C#, XAML e .NET MAUI.",
                    FontSize = 17
                }
            }
        };
    }
}