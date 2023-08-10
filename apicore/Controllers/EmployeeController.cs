using apicore.interfaceEmployee.ManagerEmployee;
using apicore.interfaceEmployee.ManagerEmployee;
using apicore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apicore.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        IEmployeeManager _employeeManager;
        public EmployeeController(IEmployeeManager employeeManager)
        {
            _employeeManager = employeeManager;
        }

        [HttpGet]

        public IActionResult Get()
        {
            //var posts = _dbContext.Posts.ToList();
            var posts = _employeeManager.GetAll().ToList();
            return Ok(posts);
        }


        private IActionResult BadRequest(object massage)
        {
            throw new NotImplementedException();
        }

        [HttpPost]

        public IActionResult Add(Employee post)
        {
            try
            {
              
                bool isSaved = _employeeManager.Add(post);
                //_dbContext.Posts.Add(post);
                //bool isSaved= _dbContext.SaveChanges()>0;
                if (isSaved)
                {
                    return Created("", post);
                }

                return BadRequest("post saved faild");

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }


        [HttpPut]
        public IActionResult Edit(Employee post)
        {

            try
            {
                if (post.Id == 0)
                {

                    return BadRequest("Id is missing");
                }

                bool isUpdate = _employeeManager.Update(post);
                if (isUpdate)
                {

                    return Ok(post);
                }

                return BadRequest("post updated faild");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("id")]

        public IActionResult Delete(int id)
        {
            try
            {

                var post = _employeeManager.GetById(id);

                if (post == null)
                {
                    return NotFound();
                }
                bool isDelete = _employeeManager.Delete(post);

                if (isDelete)
                {
                    return Ok("post has Deleted.");
                }
                return BadRequest("post delete no found");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

    }
}
