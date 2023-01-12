// See https://aka.ms/new-console-template for more information

using ClothingStore.DbConnection;
using ClothingStore.DbEntities;
using ClothingStore.Repositories;

MegaDbContext dbManager = new MegaDbContext();
ClothersRepository clothersRepository = new ClothersRepository(dbManager);

/*foreach (Clothers clother in clothersRepository.GetAllUsers())
{
     Console.WriteLine(clother.Name);
}*/

/*Clothers clothers = clothersRepository.GetById(2);
Console.WriteLine(clothers.Name);*/

/*Clothers addedClother = new Clothers() 
{
    Name = "Cапоги красивые",
    Price = 43000
};
clothersRepository.AddNew(addedClother);*/

//clothersRepository.DeleteById(5);

Clothers newUser = new Clothers()
{
     Id = 2,
     Name = "шляпа черная",
     Price = 6000
};

clothersRepository.Update(newUser);

