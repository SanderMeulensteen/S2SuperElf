using System;
using System.Collections.Generic;
using System.Text;
using DAL_Interfaces_SuperElf;
using SharedFiles;

namespace DAL_SuperElf
{
    public class PlayerDAL : IPlayerDAL
    {
        public List<PlayerDto> GetAllPlayers()
        {
            List<PlayerDto> players = new List<PlayerDto>();
            players.Add(new PlayerDto("Joel Drommel", Position.Goalkeeper, "PSV"));
            players.Add(new PlayerDto("Philipp Max", Position.Defender, "PSV"));
            players.Add(new PlayerDto("Mario Götze", Position.Midfielder, "PSV"));
            players.Add(new PlayerDto("Cody Gakpo", Position.Forward, "PSV"));
            players.Add(new PlayerDto("Maarten Stekelenburg",Position.Goalkeeper,"Ajax"));
            players.Add(new PlayerDto("Jurien Timber", Position.Defender, "Ajax"));
            players.Add(new PlayerDto("Steven Berghuis", Position.Midfielder, "Ajax"));
            players.Add(new PlayerDto("Antony", Position.Forward, "Ajax"));
            players.Add(new PlayerDto("Peter Jensen", Position.Goalkeeper, "AZ"));
            players.Add(new PlayerDto("Owen Wijndal", Position.Defender, "AZ"));
            players.Add(new PlayerDto("Fredrik Midtsjø", Position.Midfielder, "AZ"));
            players.Add(new PlayerDto("Albert Gudmundsson", Position.Forward, "AZ"));
            players.Add(new PlayerDto("Justin Bijlow", Position.Goalkeeper, "Feyenoord"));
            players.Add(new PlayerDto("Marcos Senesi", Position.Defender, "Feyenoord"));
            players.Add(new PlayerDto("Guus Til", Position.Midfielder, "Feyenoord"));
            players.Add(new PlayerDto("Bryan Linssen", Position.Forward, "Feyenoord"));
            players.Add(new PlayerDto("Sonny Stevens", Position.Goalkeeper, "SC Cambuur"));
            players.Add(new PlayerDto("Erik Schouten", Position.Defender, "SC Cambuur"));
            players.Add(new PlayerDto("Jamie Jacobs", Position.Midfielder, "SC Cambuur"));
            players.Add(new PlayerDto("Issa Kallon", Position.Forward, "SC Cambuur"));
            players.Add(new PlayerDto("Yanick van Osch", Position.Goalkeeper, "Fortuna Sittard"));
            players.Add(new PlayerDto("Ivo Pinto", Position.Defender, "Fortuna Sittard"));
            players.Add(new PlayerDto("Ben Rienstra", Position.Midfielder, "Fortuna Sittard"));
            players.Add(new PlayerDto("Mats Seuntjens", Position.Forward, "Fortuna Sittard"));
            players.Add(new PlayerDto("Warner Hahn", Position.Goalkeeper, "Go Ahead Eagles"));
            players.Add(new PlayerDto("Joris Kramer", Position.Defender, "Go Ahead Eagles"));
            players.Add(new PlayerDto("Luuk Brouwers", Position.Midfielder, "Go Ahead Eagles"));
            players.Add(new PlayerDto("Marc Cardona", Position.Forward, "Go Ahead Eagles"));
            players.Add(new PlayerDto("Peter Leeuwenburgh", Position.Goalkeeper, "FC Groningen"));
            players.Add(new PlayerDto("Bart van Hintum", Position.Defender, "FC Groningen"));
            players.Add(new PlayerDto("Tomas Suslov", Position.Midfielder, "FC Groningen"));
            players.Add(new PlayerDto("Cyril Ngonge", Position.Forward, "FC Groningen"));
            players.Add(new PlayerDto("Janis Blaswich", Position.Goalkeeper, "Heracles Almelo"));
            players.Add(new PlayerDto("Mats Knoester", Position.Defender, "Heracles Almelo"));
            players.Add(new PlayerDto("Rai Vloet", Position.Midfielder, "Heracles Almelo"));
            players.Add(new PlayerDto("Kaj Sierhuis", Position.Forward, "Heracles Almelo"));
            players.Add(new PlayerDto("Erwin Mulder", Position.Goalkeeper, "SC Heerenveen"));
            players.Add(new PlayerDto("Sven van Beek", Position.Defender, "SC Heerenveen"));
            players.Add(new PlayerDto("Joey Veerman", Position.Midfielder, "SC Heerenveen"));
            players.Add(new PlayerDto("Henk Veerman", Position.Forward, "SC Heerenveen"));
            players.Add(new PlayerDto("Mattijs Branderhorst", Position.Goalkeeper, "NEC"));
            players.Add(new PlayerDto("Rens van Eijden", Position.Defender, "NEC"));
            players.Add(new PlayerDto("Lasse Schøne", Position.Midfielder, "NEC"));
            players.Add(new PlayerDto("Ali Akman", Position.Forward, "NEC"));
            players.Add(new PlayerDto("Kostas Lamprou", Position.Goalkeeper, "PEC Zwolle"));
            players.Add(new PlayerDto("Bram van Polen", Position.Defender, "PEC Zwolle"));
            players.Add(new PlayerDto("Dean Huiberts", Position.Midfielder, "PEC Zwolle"));
            players.Add(new PlayerDto("Daishawn Redan", Position.Forward, "PEC Zwolle"));
            players.Add(new PlayerDto("Etienne Vaessen", Position.Goalkeeper, "RKC Waalwijk"));
            players.Add(new PlayerDto("Melle Meulensteen", Position.Defender, "RKC Waalwijk"));
            players.Add(new PlayerDto("Vurnon Anita", Position.Midfielder, "RKC Waalwijk"));
            players.Add(new PlayerDto("Michiel Kramer", Position.Forward, "RKC Waalwijk"));
            players.Add(new PlayerDto("Maduka Okoye", Position.Goalkeeper, "Sparta Rotterdam"));
            players.Add(new PlayerDto("Tom Beugelsdijk", Position.Defender, "Sparta Rotterdam"));
            players.Add(new PlayerDto("Bryan Smeets", Position.Midfielder, "Sparta Rotterdam"));
            players.Add(new PlayerDto("Lennart Thy", Position.Forward, "Sparta Rotterdam"));
            players.Add(new PlayerDto("Markus Schubert", Position.Goalkeeper, "Vitesse"));
            players.Add(new PlayerDto("Danilho Doekhi", Position.Defender, "Vitesse"));
            players.Add(new PlayerDto("Sondre Tronstad", Position.Midfielder, "Vitesse"));
            players.Add(new PlayerDto("Ikoma Openda", Position.Forward, "Vitesse"));
            players.Add(new PlayerDto("Timon Wellenreuther", Position.Goalkeeper, "Willem II"));
            players.Add(new PlayerDto("Emil Bergström", Position.Defender, "Willem II"));
            players.Add(new PlayerDto("Pol Llonch", Position.Midfielder, "Willem II"));
            players.Add(new PlayerDto("Che Nunnely", Position.Forward, "Willem II"));
            players.Add(new PlayerDto("Lars Unnerstal", Position.Goalkeeper, "FC Twente"));
            players.Add(new PlayerDto("Robin Propper", Position.Defender, "FC Twente"));
            players.Add(new PlayerDto("Michal Sadilek", Position.Midfielder, "FC Twente"));
            players.Add(new PlayerDto("Ricky van Wolfswinkel", Position.Forward, "FC Twente"));
            players.Add(new PlayerDto("Maarten Paes", Position.Goalkeeper, "FC Utrecht"));
            players.Add(new PlayerDto("Willem Janssen", Position.Defender, "FC Utrecht"));
            players.Add(new PlayerDto("Bart Ramselaar", Position.Midfielder, "FC Utrecht"));
            players.Add(new PlayerDto("Anastasios Douvikas", Position.Forward, "FC Utrecht"));
            return players;
        }

    }
}

