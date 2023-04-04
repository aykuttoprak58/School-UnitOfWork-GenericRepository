using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using School.BusinessLayer.Abstract;
using School.BusinessLayer.Concrete;
using School.DataAccessLayer.Repositories.Concrete;
using School.Entities;

namespace School_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        public TeacherBusiness teacherBusiness;
        public UnitOfWork UOW;
        public TeacherController(UnitOfWork unitOfWork2, TeacherBusiness teacherBusiness2)
        {

            UOW = unitOfWork2;
            teacherBusiness = teacherBusiness2;
        }

        [HttpGet]
        [Route("A")]
        public IActionResult GetAll()
        {

            var result = teacherBusiness.GetAll();

            return Ok(result);

        }

        [HttpGet]
        [Route("B")]
        public IActionResult GetById(int id)
        {

            var result = teacherBusiness.GetById(id);

            return Ok(result);

        }



        [HttpPost]
        [Route("C")]
        public IActionResult Add(Teachers entity)
        {

            teacherBusiness.Add(entity);
            UOW.Complete();

            return Ok("kayıt eklendi");
        }

        [HttpPost]
        [Route("D")]
        public IActionResult AddRange(IEnumerable<Teachers> entities)
        {

            teacherBusiness.AddRange(entities);
            UOW.Complete();
            return Ok("toplu kayıt başarılı");

        }


        [HttpDelete]
        [Route("E")]
        public IActionResult Delete(int id)
        {
            teacherBusiness.Remove(id);
            UOW.Complete();
            return Ok("Kayıt Silindi");
        }



        [HttpDelete]
        [Route("F")]
        public IActionResult RemoveRange(IEnumerable<Teachers> entities)
        {

            teacherBusiness.RemoveRange(entities);
            UOW.Complete();
            return Ok("toplu kayıt silindi");

        }

        [HttpPut]
        [Route("G")]
        public IActionResult Update(Teachers entity)
        {
            teacherBusiness.Update(entity);
            UOW.Complete();
            return Ok("kayıt güncellendi");

        }

        [HttpPut]
        [Route("H")]
        public IActionResult UpdateRange(IEnumerable<Teachers> entities)
        {
            teacherBusiness.UpdateRange(entities);
            UOW.Complete();
            return Ok("Toplu Kayıt Güncellendi");

        }



        [HttpGet]
        [Route("I")]
        public IActionResult GetTopDepartments(int count)
        {
            var results = teacherBusiness.GetTopDepartments(count);

            return Ok(results);

        }

        [HttpGet]
        [Route("K")]
        public IActionResult GetTeachersWithLessons()
        {
            var results = teacherBusiness.GetTeachersWithLessons();

            return Ok(results);

        }


    }
}
