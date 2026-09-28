namespace MauiSeminarioNovo;

public partial class MainPage : ContentPage
{
    private readonly List<string> _tarefas = new();

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnAdicionarClicked(object sender, EventArgs e)
    {
        var tarefa = TarefaEntry.Text?.Trim();

        if (string.IsNullOrWhiteSpace(tarefa))
        {
            MensagemLabel.Text = "Digite uma tarefa antes de adicionar.";
            return;
        }

        _tarefas.Add(tarefa);

        MensagemLabel.Text = $"Tarefa adicionada: {tarefa}";

        TarefaEntry.Text = string.Empty;
    }

    private async void OnDetalhesClicked(object? sender, EventArgs e)
{
    try
    {
        await Shell.Current.GoToAsync(nameof(DetalhesPage));
    }
    catch (Exception ex)
    {
        await DisplayAlert("Erro na navegação", ex.Message, "OK");
    }
 }
 
}