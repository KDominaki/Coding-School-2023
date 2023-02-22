using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Session30.EF.Repositories;
using Session30.Models;
using Session30.Web.Shared;

namespace Session30.Web.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IEntityRepo<Item> _itemRepo;
        public ItemController(IEntityRepo<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<ItemListDto>> Get()
        {
            var result = _itemRepo.GetAll();
            return result.Select(item => new ItemListDto
            {
                Id = item.Id,
                Description = item.Description,
                ItemType = item.ItemType,
                Code = item.Code,
                Price= item.Price,
                Cost= item.Cost,
            });
        }

        [HttpGet("{Id}")]
        public async Task<ItemEditDto> GetById(int id)
        {
            var result = _itemRepo.GetById(id);
            return new ItemEditDto
            {
                Id = id,
                ItemType = result.ItemType,
                Description = result.Description,
                Price = result.Price,
                Cost = result.Cost,
            };
        }

        [HttpPost]
        public async Task Post(ItemEditDto item)
        {
            var newItem = new Item(item.Price, item.Cost, item.ItemType)
            {
                Description = item.Description,
            };    
            _itemRepo.Add(newItem);
        }

        [HttpPut]
        public async Task Put(ItemEditDto item)
        {
            var itemToUpdate = _itemRepo.GetById(item.Id);

            itemToUpdate.ItemType = item.ItemType;
            itemToUpdate.Description = item.Description;
            itemToUpdate.Price = item.Price;
            itemToUpdate.Cost = item.Cost;
            _itemRepo.Update(item.Id, itemToUpdate);
        }

        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {

            _itemRepo.Delete(id);
        }
    }
}
