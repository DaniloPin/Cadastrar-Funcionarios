public class Funcionario {
   

    public string Nome {  get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, string cargo) {
        Nome = nome;
        Cargo = cargo;
    }

    public void Promover (string novoCargo) {
        
        if (Cargo != novoCargo) {
           
            Cargo = novoCargo;
            Console.WriteLine("Promovido com sucesso!");
        } 
        else {
            Console.WriteLine("O novo cargo deve ser diferente do atual.");
        }
    }
}