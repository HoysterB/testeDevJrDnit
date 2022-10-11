﻿namespace TesteVagaJr.Domain.Entities;

public class Fornecedor : Entity
{
    public string Nome { get; private set; }
    public string NumeroDocumento { get; private set; }
    public ETipoDocumento TipoDocumento { get; private set; }
    public ETipoFornecedor TipoFornecedor { get; private set; }
    public DateTime DataHoraCadastro { get; set; }
    public List<Telefone> Telefones { get; private set; }
    public DateTime? DataNascimento { get; private set; }
    public string RG { get; private set; }

    public Guid EmpresaId { get; private set; }
    public Empresa Empresa { get; set; }

    protected Fornecedor() { }

    public Fornecedor(string nome, string numeroDocumento, ETipoDocumento tipoDocumento, DateTime? dataNascimento, string? rg, Guid empresaId)
    {
        Nome = nome;
        NumeroDocumento = numeroDocumento;
        TipoDocumento = tipoDocumento;
        DataHoraCadastro = DateTime.Now;
        DataNascimento = dataNascimento;
        RG = rg;

        EmpresaId = empresaId;
    }

    public void AdicionarTelefone(string DDD, string numero)
    {
        var telefone = new Telefone(DDD, numero);
        Telefones.Add(telefone);
    }

    public void RemoverTelefone(string numero)
    {
        var telefone = Telefones.FirstOrDefault(x => x.Numero == numero);
        Telefones.Remove(telefone);
    }

    public override bool Validate()
    {
        throw new NotImplementedException();
    }
}
