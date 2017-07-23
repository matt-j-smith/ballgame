using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ballgame
{
    [XmlRoot(ElementName = "inning_line_score")]
    public class Inning_line_score
    {
        [XmlAttribute(AttributeName = "away")]
        public string Away { get; set; }
        [XmlAttribute(AttributeName = "home")]
        public string Home { get; set; }
        [XmlAttribute(AttributeName = "inning")]
        public string Inning { get; set; }
    }

    [XmlRoot(ElementName = "linescore")]
    public class Linescore
    {
        [XmlElement(ElementName = "inning_line_score")]
        public List<Inning_line_score> Inning_line_score { get; set; }
        [XmlAttribute(AttributeName = "away_team_runs")]
        public string Away_team_runs { get; set; }
        [XmlAttribute(AttributeName = "home_team_runs")]
        public string Home_team_runs { get; set; }
        [XmlAttribute(AttributeName = "away_team_hits")]
        public string Away_team_hits { get; set; }
        [XmlAttribute(AttributeName = "home_team_hits")]
        public string Home_team_hits { get; set; }
        [XmlAttribute(AttributeName = "away_team_errors")]
        public string Away_team_errors { get; set; }
        [XmlAttribute(AttributeName = "home_team_errors")]
        public string Home_team_errors { get; set; }
    }

    [XmlRoot(ElementName = "pitcher")]
    public class Pitcher
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "name_display_first_last")]
        public string Name_display_first_last { get; set; }
        [XmlAttribute(AttributeName = "pos")]
        public string Pos { get; set; }
        [XmlAttribute(AttributeName = "out")]
        public string Out { get; set; }
        [XmlAttribute(AttributeName = "bf")]
        public string Bf { get; set; }
        [XmlAttribute(AttributeName = "er")]
        public string Er { get; set; }
        [XmlAttribute(AttributeName = "r")]
        public string R { get; set; }
        [XmlAttribute(AttributeName = "h")]
        public string H { get; set; }
        [XmlAttribute(AttributeName = "so")]
        public string So { get; set; }
        [XmlAttribute(AttributeName = "hr")]
        public string Hr { get; set; }
        [XmlAttribute(AttributeName = "bb")]
        public string Bb { get; set; }
        [XmlAttribute(AttributeName = "np")]
        public string Np { get; set; }
        [XmlAttribute(AttributeName = "s")]
        public string S { get; set; }
        [XmlAttribute(AttributeName = "w")]
        public string W { get; set; }
        [XmlAttribute(AttributeName = "l")]
        public string L { get; set; }
        [XmlAttribute(AttributeName = "sv")]
        public string Sv { get; set; }
        [XmlAttribute(AttributeName = "bs")]
        public string Bs { get; set; }
        [XmlAttribute(AttributeName = "hld")]
        public string Hld { get; set; }
        [XmlAttribute(AttributeName = "s_ip")]
        public string S_ip { get; set; }
        [XmlAttribute(AttributeName = "s_h")]
        public string S_h { get; set; }
        [XmlAttribute(AttributeName = "s_r")]
        public string S_r { get; set; }
        [XmlAttribute(AttributeName = "s_er")]
        public string S_er { get; set; }
        [XmlAttribute(AttributeName = "s_bb")]
        public string S_bb { get; set; }
        [XmlAttribute(AttributeName = "s_so")]
        public string S_so { get; set; }
        [XmlAttribute(AttributeName = "game_score")]
        public string Game_score { get; set; }
        [XmlAttribute(AttributeName = "era")]
        public string Era { get; set; }
        [XmlAttribute(AttributeName = "loss")]
        public string Loss { get; set; }
        [XmlAttribute(AttributeName = "note")]
        public string Note { get; set; }
        [XmlAttribute(AttributeName = "win")]
        public string Win { get; set; }
    }

    [XmlRoot(ElementName = "pitching")]
    public class Pitching
    {
        [XmlElement(ElementName = "pitcher")]
        public List<Pitcher> Pitcher { get; set; }
        [XmlAttribute(AttributeName = "team_flag")]
        public string Team_flag { get; set; }
        [XmlAttribute(AttributeName = "out")]
        public string Out { get; set; }
        [XmlAttribute(AttributeName = "h")]
        public string H { get; set; }
        [XmlAttribute(AttributeName = "r")]
        public string R { get; set; }
        [XmlAttribute(AttributeName = "er")]
        public string Er { get; set; }
        [XmlAttribute(AttributeName = "bb")]
        public string Bb { get; set; }
        [XmlAttribute(AttributeName = "so")]
        public string So { get; set; }
        [XmlAttribute(AttributeName = "hr")]
        public string Hr { get; set; }
        [XmlAttribute(AttributeName = "bf")]
        public string Bf { get; set; }
        [XmlAttribute(AttributeName = "era")]
        public string Era { get; set; }
    }

    [XmlRoot(ElementName = "batter")]
    public class Batter
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
        [XmlAttribute(AttributeName = "name_display_first_last")]
        public string Name_display_first_last { get; set; }
        [XmlAttribute(AttributeName = "pos")]
        public string Pos { get; set; }
        [XmlAttribute(AttributeName = "bo")]
        public string Bo { get; set; }
        [XmlAttribute(AttributeName = "ab")]
        public string Ab { get; set; }
        [XmlAttribute(AttributeName = "po")]
        public string Po { get; set; }
        [XmlAttribute(AttributeName = "r")]
        public string R { get; set; }
        [XmlAttribute(AttributeName = "a")]
        public string A { get; set; }
        [XmlAttribute(AttributeName = "bb")]
        public string Bb { get; set; }
        [XmlAttribute(AttributeName = "sac")]
        public string Sac { get; set; }
        [XmlAttribute(AttributeName = "t")]
        public string T { get; set; }
        [XmlAttribute(AttributeName = "sf")]
        public string Sf { get; set; }
        [XmlAttribute(AttributeName = "h")]
        public string H { get; set; }
        [XmlAttribute(AttributeName = "e")]
        public string E { get; set; }
        [XmlAttribute(AttributeName = "d")]
        public string D { get; set; }
        [XmlAttribute(AttributeName = "hbp")]
        public string Hbp { get; set; }
        [XmlAttribute(AttributeName = "so")]
        public string So { get; set; }
        [XmlAttribute(AttributeName = "hr")]
        public string Hr { get; set; }
        [XmlAttribute(AttributeName = "rbi")]
        public string Rbi { get; set; }
        [XmlAttribute(AttributeName = "lob")]
        public string Lob { get; set; }
        [XmlAttribute(AttributeName = "fldg")]
        public string Fldg { get; set; }
        [XmlAttribute(AttributeName = "sb")]
        public string Sb { get; set; }
        [XmlAttribute(AttributeName = "cs")]
        public string Cs { get; set; }
        [XmlAttribute(AttributeName = "s_hr")]
        public string S_hr { get; set; }
        [XmlAttribute(AttributeName = "s_rbi")]
        public string S_rbi { get; set; }
        [XmlAttribute(AttributeName = "s_h")]
        public string S_h { get; set; }
        [XmlAttribute(AttributeName = "s_bb")]
        public string S_bb { get; set; }
        [XmlAttribute(AttributeName = "s_r")]
        public string S_r { get; set; }
        [XmlAttribute(AttributeName = "s_so")]
        public string S_so { get; set; }
        [XmlAttribute(AttributeName = "avg")]
        public string Avg { get; set; }
        [XmlAttribute(AttributeName = "obp")]
        public string Obp { get; set; }
        [XmlAttribute(AttributeName = "slg")]
        public string Slg { get; set; }
        [XmlAttribute(AttributeName = "ops")]
        public string Ops { get; set; }
        [XmlAttribute(AttributeName = "ao")]
        public string Ao { get; set; }
        [XmlAttribute(AttributeName = "go")]
        public string Go { get; set; }
        [XmlAttribute(AttributeName = "gidp")]
        public string Gidp { get; set; }
        [XmlAttribute(AttributeName = "note")]
        public string Note { get; set; }
    }

    [XmlRoot(ElementName = "batting")]
    public class Batting
    {
        [XmlElement(ElementName = "batter")]
        public List<Batter> Batter { get; set; }
        [XmlElement(ElementName = "text_data")]
        public string Text_data { get; set; }
        [XmlElement(ElementName = "text_data_es")]
        public string Text_data_es { get; set; }
        [XmlAttribute(AttributeName = "team_flag")]
        public string Team_flag { get; set; }
        [XmlAttribute(AttributeName = "ab")]
        public string Ab { get; set; }
        [XmlAttribute(AttributeName = "r")]
        public string R { get; set; }
        [XmlAttribute(AttributeName = "h")]
        public string H { get; set; }
        [XmlAttribute(AttributeName = "d")]
        public string D { get; set; }
        [XmlAttribute(AttributeName = "t")]
        public string T { get; set; }
        [XmlAttribute(AttributeName = "hr")]
        public string Hr { get; set; }
        [XmlAttribute(AttributeName = "rbi")]
        public string Rbi { get; set; }
        [XmlAttribute(AttributeName = "bb")]
        public string Bb { get; set; }
        [XmlAttribute(AttributeName = "po")]
        public string Po { get; set; }
        [XmlAttribute(AttributeName = "da")]
        public string Da { get; set; }
        [XmlAttribute(AttributeName = "so")]
        public string So { get; set; }
        [XmlAttribute(AttributeName = "lob")]
        public string Lob { get; set; }
        [XmlAttribute(AttributeName = "avg")]
        public string Avg { get; set; }
        [XmlAttribute(AttributeName = "obp")]
        public string Obp { get; set; }
        [XmlAttribute(AttributeName = "slg")]
        public string Slg { get; set; }
        [XmlAttribute(AttributeName = "ops")]
        public string Ops { get; set; }
        [XmlElement(ElementName = "note")]
        public string Note { get; set; }
        [XmlElement(ElementName = "note_es")]
        public string Note_es { get; set; }
    }

    [XmlRoot(ElementName = "boxscore")]
    public class Boxscore
    {
        [XmlElement(ElementName = "linescore")]
        public Linescore Linescore { get; set; }
        [XmlElement(ElementName = "pitching")]
        public List<Pitching> Pitching { get; set; }
        [XmlElement(ElementName = "batting")]
        public List<Batting> Batting { get; set; }
        [XmlElement(ElementName = "game_info")]
        public string Game_info { get; set; }
        [XmlElement(ElementName = "game_info_es")]
        public string Game_info_es { get; set; }
        [XmlAttribute(AttributeName = "game_id")]
        public string Game_id { get; set; }
        [XmlAttribute(AttributeName = "game_pk")]
        public string Game_pk { get; set; }
        [XmlAttribute(AttributeName = "venue_id")]
        public string Venue_id { get; set; }
        [XmlAttribute(AttributeName = "venue_name")]
        public string Venue_name { get; set; }
        [XmlAttribute(AttributeName = "home_sport_code")]
        public string Home_sport_code { get; set; }
        [XmlAttribute(AttributeName = "away_team_code")]
        public string Away_team_code { get; set; }
        [XmlAttribute(AttributeName = "home_team_code")]
        public string Home_team_code { get; set; }
        [XmlAttribute(AttributeName = "away_id")]
        public string Away_id { get; set; }
        [XmlAttribute(AttributeName = "home_id")]
        public string Home_id { get; set; }
        [XmlAttribute(AttributeName = "away_fname")]
        public string Away_fname { get; set; }
        [XmlAttribute(AttributeName = "home_fname")]
        public string Home_fname { get; set; }
        [XmlAttribute(AttributeName = "away_sname")]
        public string Away_sname { get; set; }
        [XmlAttribute(AttributeName = "home_sname")]
        public string Home_sname { get; set; }
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "away_wins")]
        public string Away_wins { get; set; }
        [XmlAttribute(AttributeName = "away_loss")]
        public string Away_loss { get; set; }
        [XmlAttribute(AttributeName = "home_wins")]
        public string Home_wins { get; set; }
        [XmlAttribute(AttributeName = "home_loss")]
        public string Home_loss { get; set; }
        [XmlAttribute(AttributeName = "status_ind")]
        public string Status_ind { get; set; }
    }   
}