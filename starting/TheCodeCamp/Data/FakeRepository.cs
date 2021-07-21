using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace TheCodeCamp.Data
{
    public class FakeRepository : ICampRepository
    {
        public void AddCamp(Camp camp)
        {
            throw new NotImplementedException();
        }

        public void AddSpeaker(Speaker speaker)
        {
            throw new NotImplementedException();
        }

        public void AddTalk(Talk talk)
        {
            throw new NotImplementedException();
        }

        public void DeleteCamp(Camp camp)
        {
            throw new NotImplementedException();
        }

        public void DeleteSpeaker(Speaker speaker)
        {
            throw new NotImplementedException();
        }

        public void DeleteTalk(Talk talk)
        {
            throw new NotImplementedException();
        }

        public Task<Camp[]> GetAllCampsAsync(bool includeTalks = false)
        {
            throw new NotImplementedException();
        }

        public Task<Camp[]> GetAllCampsByEventDate(DateTime dateTime, bool includeTalks = false)
        {
            throw new NotImplementedException();
        }

        public Task<Speaker[]> GetAllSpeakersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Camp> GetCampAsync(string moniker, bool includeTalks = false)
        {
            throw new NotImplementedException();
        }

        public Task<Speaker> GetSpeakerAsync(int speakerId)
        {
            throw new NotImplementedException();
        }

        public Task<Speaker[]> GetSpeakersByMonikerAsync(string moniker)
        {
            throw new NotImplementedException();
        }

        public Task<Talk> GetTalkByMonikerAsync(string moniker, int talkId, bool includeSpeakers = false)
        {
            throw new NotImplementedException();
        }

        public Task<Talk[]> GetTalksByMonikerAsync(string moniker, bool includeSpeakers = false)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}