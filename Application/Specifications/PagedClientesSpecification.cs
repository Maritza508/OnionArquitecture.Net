using Application.Features.Clientes.Queries.GetAllClientes;
using Ardalis.Specification;
using Domain.Entities;
using System.Security.Cryptography;

namespace Application.Specifications
{
    public class PagedClientesSpecification : Specification<Cliente>
    {
        public PagedClientesSpecification(GetAllClientesQuery parameters)
        {
            Query.Skip((parameters.Pagination.PageNumber - 1) * parameters.Pagination.PageSize)
                 .Take(parameters.Pagination.PageSize);

            if (!string.IsNullOrEmpty(parameters.Pagination.Nombre))
                Query.Search(x => x.Nombre, "%" + parameters.Pagination.Nombre + "%");

            if (!string.IsNullOrEmpty(parameters.Pagination.Apellidos))
                Query.Search(x => x.Apellido, "%" + parameters.Pagination.Apellidos + "%");
        }
    }
}
