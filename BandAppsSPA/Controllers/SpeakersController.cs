using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace BandAppsSPA.Controllers
{
    public class SpeakersController : ApiController
    {
        // GET api/speakers
        public IEnumerable<object> Get()
        {
            var ctx = new BandAppsSPADbContext();
            var query = ctx.Set<Session>()
                .Select(session => session.Speaker)
                .Distinct().Select(s =>
                    new 
                        {    
                                Id = s.Id,
                                FirstName = s.FirstName,
                                LastName = s.LastName,
                                ImageSource = s.ImageSource,
                        });
            return query;
        }
    }
}
