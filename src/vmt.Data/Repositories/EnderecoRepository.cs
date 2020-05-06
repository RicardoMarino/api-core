using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using vmt.Business.Interfaces;
using vmt.Business.Models;
using vmt.Data.Context;

namespace vmt.Data.Repositories
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(DataDbContext context) : base(context) { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.AsNoTracking()
                .FirstOrDefaultAsync(f => f.FornecedorId == fornecedorId);
        }
    }
}
