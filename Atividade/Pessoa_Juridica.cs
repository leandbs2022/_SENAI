namespace Atividade
{
    class Pessoa_Juridica : Clientes
    {
        public string cnpj{ get; set; }
        public string ie{ get; set; }
    }
 //não aceitou o comando Override no restante esta funcionado, falar que a strutura ja existe

   /* public override void Pagar_Imposto(float v)
    {
        this.valor = v;
        this.valor_imposto = this.valor * 20 / 100;
        this.total = this.valor + this.valor_imposto;//
    }*/
}