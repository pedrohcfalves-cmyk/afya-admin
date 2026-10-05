using MudBlazor;

namespace afya_admin.Data;

public static class DadosFake
{
    public static readonly string[] Periodos = ["3 meses", "6 meses", "12 meses"];

    private static readonly string[] _meses =
        ["Jan", "Fev", "Mar", "Abr", "Mai", "Jun", "Jul", "Ago", "Set", "Out", "Nov", "Dez"];

    private static readonly double[] _receita = [42, 48, 45, 53, 58, 62, 60, 68, 72, 70, 78, 85];
    private static readonly double[] _meta = [40, 45, 50, 52, 56, 60, 64, 66, 70, 74, 78, 82];

    public static SerieFinanceira ObterReceitaMeta(string periodo)
    {
        int quantidade = periodo switch
        {
            "3 meses" => 3,
            "6 meses" => 6,
            _ => 12,
        };

        return new SerieFinanceira(
            _meses[^quantidade..],
            _receita[^quantidade..],
            _meta[^quantidade..]);
    }

    public static readonly IReadOnlyList<KpiInfo> Kpis =
    [
        new("Receita Total", "R$ 128,4 mil", 12.5, Icons.Material.Filled.AttachMoney, Color.Success,
            [32, 38, 35, 44, 41, 52, 58]),
        new("Novos Clientes", "1.248", 8.2, Icons.Material.Filled.People, Color.Info,
            [20, 26, 24, 30, 33, 31, 38]),
        new("Projetos Ativos", "36", -3.1, Icons.Material.Filled.Folder, Color.Warning,
            [44, 41, 46, 40, 39, 42, 36]),
        new("Taxa de Conclusão", "87%", 4.7, Icons.Material.Filled.TaskAlt, Color.Primary,
            [70, 72, 75, 74, 80, 83, 87]),
    ];

    public static readonly string[] RotulosClientes = ["Empresas", "Startups", "Educação", "Saúde"];
    public static readonly double[] ValoresClientes = [420, 310, 280, 238];

    public static readonly IReadOnlyList<ProjetoDesempenho> Desempenho =
    [
        new("Portal do Aluno", 92, Color.Success),
        new("App Mobile Afya", 75, Color.Info),
        new("Plataforma EAD", 64, Color.Primary),
        new("Migração de Dados", 48, Color.Warning),
        new("Integração ERP", 31, Color.Error),
    ];

    public static readonly IReadOnlyList<Atividade> Atividades =
    [
        new("Ana Souza", "concluiu a tarefa Revisão de conteúdo", "há 5 min", Icons.Material.Filled.CheckCircle, Color.Success),
        new("Carlos Lima", "comentou no projeto Plataforma EAD", "há 22 min", Icons.Material.Filled.Comment, Color.Info),
        new("Beatriz Rocha", "enviou o relatório mensal", "há 1 h", Icons.Material.Filled.UploadFile, Color.Primary),
        new("Diego Martins", "atrasou a entrega da Integração ERP", "há 3 h", Icons.Material.Filled.Warning, Color.Warning),
        new("Fernanda Alves", "cadastrou um novo cliente", "ontem", Icons.Material.Filled.PersonAdd, Color.Secondary),
    ];

    public static readonly IReadOnlyList<ProjetoRecente> ProjetosRecentes =
    [
        new("Portal do Aluno", "Ana Souza", "Em andamento", new DateOnly(2026, 11, 15), 92),
        new("App Mobile Afya", "Carlos Lima", "Em andamento", new DateOnly(2026, 12, 10), 75),
        new("Plataforma EAD", "Beatriz Rocha", "Planejado", new DateOnly(2027, 1, 20), 64),
        new("Migração de Dados", "Diego Martins", "Atrasado", new DateOnly(2026, 10, 30), 48),
        new("Integração ERP", "Fernanda Alves", "Atrasado", new DateOnly(2026, 10, 25), 31),
        new("Biblioteca Digital", "Gustavo Reis", "Concluído", new DateOnly(2026, 9, 28), 100),
    ];
}
