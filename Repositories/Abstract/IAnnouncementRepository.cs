using Entities.Models;

namespace Repositories.Abstract
{
    public interface IAnnouncementRepository
    {
        void AddAd(Announcement announcement);
        void UpdateAd(Announcement announcement);
        void DeleteAd(int announcementID);
        List<Announcement> GetAllAnnouncements(int userID);
    }
}