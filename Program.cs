Funcionario func = new Funcionario("Danilo Pinheiro", "Demitido");

Console.WriteLine($"Nome do Funcionário: {func.Nome}");
Console.WriteLine($"Cargo atual: {func.Cargo}\n");

func.Promover("Maratonista");
func.Promover("Judoca");

Console.WriteLine("\n------ Após Promoção --------");

Console.WriteLine($"\nNome do funcionário: {func.Nome}");
Console.WriteLine($"Nova função: {func.Cargo}");