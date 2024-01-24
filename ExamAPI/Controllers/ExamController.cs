using ExamAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExamAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExamController : ControllerBase
    {

        private readonly ExamContext _dbContext;

        public ExamController(ExamContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exam>>> GetExams()
        {
            if (_dbContext.exams == null)
            {
                return NotFound();
            }

            return await _dbContext.exams.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Exam>> GetExam(int id)
        {
            if (_dbContext.exams == null)
            {
                return NotFound();
            }

            var exam = await _dbContext.exams.FindAsync(id);

            if (exam == null)
            {
                return NotFound();
            }
            return exam;
        }


        [HttpPost]

        public async Task<ActionResult<Exam>> PostExam(Exam exam)
        {
            _dbContext.exams.Add(exam);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetExam), new { id = exam.Id }, exam);
        }
        [HttpPut]
        public async Task<ActionResult> PutExam(int id, Exam exam)
        {
            if (id != exam.Id)
            {
            return BadRequest();
            }
            _dbContext.Entry(exam).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch(DbUpdateConcurrencyException)
            {
                if(!ExamAvailable(id))
                {
                    return NotFound();

                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }
        private bool ExamAvailable(int id)
        {
            return (_dbContext.exams?.Any(x => x.Id == id)).GetValueOrDefault();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExam(int id)
        {
            if(_dbContext.exams == null)
            {
                return NotFound();
            }
            var exam = await _dbContext.exams.FindAsync(id);
            if(exam == null)
            {
                return NotFound();
            }
            _dbContext.exams.Remove(exam);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}
