using Microsoft.AspNetCore.Mvc;
using simpsoms_net_web_ap.Models;
using System.Collections.Generic;

namespace simpsoms_net_web_api.Dependencies
{
    public interface ICharacter
    {
        Character GetCharacter(int id);

        List<Character> GetCharacterList();
        
    }
}
