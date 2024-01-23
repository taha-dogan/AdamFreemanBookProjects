using System.Collections.Generic;

namespace BookProjectTwo.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>(); //nesnelerin tutulduğu bir liste oluşturur
        public static IEnumerable<GuestResponse> Responses => responses; //listeyi dışarıdan okunabilir hale getirir
        public static void AddResponse(GuestResponse response) //GuestResponse türünden yeni bir konuğun yanıtını responses listesine ekler
        {
            responses.Add(response);
        }
    }
}
