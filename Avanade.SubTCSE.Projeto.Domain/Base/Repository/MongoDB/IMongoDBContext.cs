using MongoDB.Driver;
//ACID
namespace Avanade.SubTCSE.Projeto.Domain.Base.Repository.MongoDB

{
    public interface IMongoDBContext
    {
        IMongoCollection<TEntity> GetCollection<TEntity>(string collection);
    }
}
