namespace MauiSeminarioNovo;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute("DetalhesPage", typeof(DetalhesPage));
    }
}