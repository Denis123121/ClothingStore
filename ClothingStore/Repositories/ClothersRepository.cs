using ClothingStore.DbConnection;
using ClothingStore.DbEntities;

namespace ClothingStore.Repositories;

public class ClothersRepository
{
    private MegaDbContext _dbManager;

    public ClothersRepository(MegaDbContext dbManager)
    {
        _dbManager = dbManager;
    }
    
    public List<Clothers> GetAllUsers()
    {
        return _dbManager.Clothes.ToList();
    }

    public Clothers GetById(int id)
    {
        return _dbManager.Clothes.First(clothers => clothers.Id == id);
    }
    
    public void AddNew(Clothers clother)
    {
        _dbManager.Clothes.Add(clother);
        _dbManager.SaveChanges();
    }
    
    public void DeleteById(int clotherId)
    {
        Clothers clother = _dbManager.Clothes.First(clother => clother.Id == clotherId);
        _dbManager.Clothes.Remove(clother);
        _dbManager.SaveChanges();
    }
    
    public void Update(Clothers newClother)
    {
        Clothers oldClother = _dbManager.Clothes.First(clother => clother.Id == newClother.Id);

        oldClother.Name = newClother.Name;
        oldClother.Price = newClother.Price;

        _dbManager.SaveChanges();
    }

}