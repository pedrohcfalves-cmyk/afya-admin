using MudBlazor;

namespace afya_admin.Data;

public record KpiInfo(string Titulo, string Valor, double Variacao, string Icone, Color Cor, double[] Tendencia);
