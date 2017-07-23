/*# DON'T BE A DICK PUBLIC LICENSE

> Version 1.1, December 2016

> Copyright (C) [2017] [Matt Smith] [matt@mattsmithcodesmith.com]
 
 Everyone is permitted to copy and distribute verbatim or modified
 copies of this license document.

> DON'T BE A DICK PUBLIC LICENSE
> TERMS AND CONDITIONS FOR COPYING, DISTRIBUTION AND MODIFICATION

 1. Do whatever you like with the original work, just don't be a dick.

     Being a dick includes - but is not limited to - the following instances:

	 1a. Outright copyright infringement - Don't just copy this and change the name.  
	 1b. Selling the unmodified original with no work done what-so-ever, that's REALLY being a dick.  
	 1c. Modifying the original work to contain hidden harmful content. That would make you a PROPER dick.  

 2. If you become rich through modifications, related works/services, or supporting the original work,
 share the love. Only a dick would make loads off this work and not buy the original work's 
 creator(s) a pint.
 
 3. Code is provided with no warranty. Using somebody else's code and bitching when it goes wrong makes 
 you a DONKEY dick. Fix the problem yourself. A non-dick would submit the fix back.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ballgame
{
    [XmlRoot(ElementName = "media")]
    public class Media
    {
        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
        [XmlAttribute(AttributeName = "calendar_event_id")]
        public string Calendar_event_id { get; set; }
        [XmlAttribute(AttributeName = "start")]
        public string Start { get; set; }
        [XmlAttribute(AttributeName = "title")]
        public string Title { get; set; }
        [XmlAttribute(AttributeName = "has_mlbtv")]
        public string Has_mlbtv { get; set; }
        [XmlAttribute(AttributeName = "free")]
        public string Free { get; set; }
        [XmlAttribute(AttributeName = "enhanced")]
        public string Enhanced { get; set; }
        [XmlAttribute(AttributeName = "media_state")]
        public string Media_state { get; set; }
        [XmlAttribute(AttributeName = "thumbnail")]
        public string Thumbnail { get; set; }
        [XmlAttribute(AttributeName = "content_id")]
        public string Content_id { get; set; }
        [XmlAttribute(AttributeName = "topic_id")]
        public string Topic_id { get; set; }
        [XmlAttribute(AttributeName = "headline")]
        public string Headline { get; set; }
    }

    [XmlRoot(ElementName = "game_media")]
    public class Game_media
    {
        [XmlElement(ElementName = "media")]
        public List<Media> Media { get; set; }
    }

    [XmlRoot(ElementName = "game")]
    public class Game
    {
        [XmlElement(ElementName = "game_media")]
        public Game_media Game_media { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "venue")]
        public string Venue { get; set; }
        [XmlAttribute(AttributeName = "game_pk")]
        public string Game_pk { get; set; }
        [XmlAttribute(AttributeName = "time")]
        public string Time { get; set; }
        [XmlAttribute(AttributeName = "time_date")]
        public string Time_date { get; set; }
        [XmlAttribute(AttributeName = "time_date_aw_lg")]
        public string Time_date_aw_lg { get; set; }
        [XmlAttribute(AttributeName = "time_date_hm_lg")]
        public string Time_date_hm_lg { get; set; }
        [XmlAttribute(AttributeName = "time_zone")]
        public string Time_zone { get; set; }
        [XmlAttribute(AttributeName = "ampm")]
        public string Ampm { get; set; }
        [XmlAttribute(AttributeName = "away_time")]
        public string Away_time { get; set; }
        [XmlAttribute(AttributeName = "away_time_zone")]
        public string Away_time_zone { get; set; }
        [XmlAttribute(AttributeName = "away_ampm")]
        public string Away_ampm { get; set; }
        [XmlAttribute(AttributeName = "home_time")]
        public string Home_time { get; set; }
        [XmlAttribute(AttributeName = "home_time_zone")]
        public string Home_time_zone { get; set; }
        [XmlAttribute(AttributeName = "home_ampm")]
        public string Home_ampm { get; set; }
        [XmlAttribute(AttributeName = "game_type")]
        public string Game_type { get; set; }
        [XmlAttribute(AttributeName = "tiebreaker_sw")]
        public string Tiebreaker_sw { get; set; }
        [XmlAttribute(AttributeName = "original_date")]
        public string Original_date { get; set; }
        [XmlAttribute(AttributeName = "time_zone_aw_lg")]
        public string Time_zone_aw_lg { get; set; }
        [XmlAttribute(AttributeName = "time_zone_hm_lg")]
        public string Time_zone_hm_lg { get; set; }
        [XmlAttribute(AttributeName = "time_aw_lg")]
        public string Time_aw_lg { get; set; }
        [XmlAttribute(AttributeName = "aw_lg_ampm")]
        public string Aw_lg_ampm { get; set; }
        [XmlAttribute(AttributeName = "tz_aw_lg_gen")]
        public string Tz_aw_lg_gen { get; set; }
        [XmlAttribute(AttributeName = "time_hm_lg")]
        public string Time_hm_lg { get; set; }
        [XmlAttribute(AttributeName = "hm_lg_ampm")]
        public string Hm_lg_ampm { get; set; }
        [XmlAttribute(AttributeName = "tz_hm_lg_gen")]
        public string Tz_hm_lg_gen { get; set; }
        [XmlAttribute(AttributeName = "venue_id")]
        public string Venue_id { get; set; }
        [XmlAttribute(AttributeName = "scheduled_innings")]
        public string Scheduled_innings { get; set; }
        [XmlAttribute(AttributeName = "away_name_abbrev")]
        public string Away_name_abbrev { get; set; }
        [XmlAttribute(AttributeName = "home_name_abbrev")]
        public string Home_name_abbrev { get; set; }
        [XmlAttribute(AttributeName = "away_code")]
        public string Away_code { get; set; }
        [XmlAttribute(AttributeName = "away_file_code")]
        public string Away_file_code { get; set; }
        [XmlAttribute(AttributeName = "away_team_id")]
        public string Away_team_id { get; set; }
        [XmlAttribute(AttributeName = "away_team_city")]
        public string Away_team_city { get; set; }
        [XmlAttribute(AttributeName = "away_team_name")]
        public string Away_team_name { get; set; }
        [XmlAttribute(AttributeName = "away_division")]
        public string Away_division { get; set; }
        [XmlAttribute(AttributeName = "away_league_id")]
        public string Away_league_id { get; set; }
        [XmlAttribute(AttributeName = "away_sport_code")]
        public string Away_sport_code { get; set; }
        [XmlAttribute(AttributeName = "home_code")]
        public string Home_code { get; set; }
        [XmlAttribute(AttributeName = "home_file_code")]
        public string Home_file_code { get; set; }
        [XmlAttribute(AttributeName = "home_team_id")]
        public string Home_team_id { get; set; }
        [XmlAttribute(AttributeName = "home_team_city")]
        public string Home_team_city { get; set; }
        [XmlAttribute(AttributeName = "home_team_name")]
        public string Home_team_name { get; set; }
        [XmlAttribute(AttributeName = "home_division")]
        public string Home_division { get; set; }
        [XmlAttribute(AttributeName = "home_league_id")]
        public string Home_league_id { get; set; }
        [XmlAttribute(AttributeName = "home_sport_code")]
        public string Home_sport_code { get; set; }
        [XmlAttribute(AttributeName = "day")]
        public string Day { get; set; }
        [XmlAttribute(AttributeName = "gameday_sw")]
        public string Gameday_sw { get; set; }
        [XmlAttribute(AttributeName = "double_header_sw")]
        public string Double_header_sw { get; set; }
        [XmlAttribute(AttributeName = "game_nbr")]
        public string Game_nbr { get; set; }
        [XmlAttribute(AttributeName = "tbd_flag")]
        public string Tbd_flag { get; set; }
        [XmlAttribute(AttributeName = "away_games_back")]
        public string Away_games_back { get; set; }
        [XmlAttribute(AttributeName = "home_games_back")]
        public string Home_games_back { get; set; }
        [XmlAttribute(AttributeName = "home_games_back_wildcard")]
        public string Home_games_back_wildcard { get; set; }
        [XmlAttribute(AttributeName = "venue_w_chan_loc")]
        public string Venue_w_chan_loc { get; set; }
        [XmlAttribute(AttributeName = "location")]
        public string Location { get; set; }
        [XmlAttribute(AttributeName = "gameday_link")]
        public string Gameday_link { get; set; }
        [XmlAttribute(AttributeName = "away_win")]
        public string Away_win { get; set; }
        [XmlAttribute(AttributeName = "away_loss")]
        public string Away_loss { get; set; }
        [XmlAttribute(AttributeName = "home_win")]
        public string Home_win { get; set; }
        [XmlAttribute(AttributeName = "home_loss")]
        public string Home_loss { get; set; }
        [XmlAttribute(AttributeName = "game_data_directory")]
        public string Game_data_directory { get; set; }
        [XmlAttribute(AttributeName = "league")]
        public string League { get; set; }
        [XmlAttribute(AttributeName = "top_inning")]
        public string Top_inning { get; set; }
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
        [XmlAttribute(AttributeName = "ind")]
        public string Ind { get; set; }
        [XmlAttribute(AttributeName = "inning")]
        public string Inning { get; set; }
        [XmlAttribute(AttributeName = "outs")]
        public string Outs { get; set; }
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
        [XmlAttribute(AttributeName = "away_team_hr")]
        public string Away_team_hr { get; set; }
        [XmlAttribute(AttributeName = "home_team_hr")]
        public string Home_team_hr { get; set; }
        [XmlAttribute(AttributeName = "away_team_sb")]
        public string Away_team_sb { get; set; }
        [XmlAttribute(AttributeName = "home_team_sb")]
        public string Home_team_sb { get; set; }
        [XmlAttribute(AttributeName = "away_team_so")]
        public string Away_team_so { get; set; }
        [XmlAttribute(AttributeName = "home_team_so")]
        public string Home_team_so { get; set; }
        [XmlAttribute(AttributeName = "mlbtv_link")]
        public string Mlbtv_link { get; set; }
        [XmlAttribute(AttributeName = "wrapup_link")]
        public string Wrapup_link { get; set; }
        [XmlAttribute(AttributeName = "home_audio_link")]
        public string Home_audio_link { get; set; }
        [XmlAttribute(AttributeName = "away_audio_link")]
        public string Away_audio_link { get; set; }
        [XmlAttribute(AttributeName = "home_preview_link")]
        public string Home_preview_link { get; set; }
        [XmlAttribute(AttributeName = "away_preview_link")]
        public string Away_preview_link { get; set; }
        [XmlAttribute(AttributeName = "preview_link")]
        public string Preview_link { get; set; }
        [XmlAttribute(AttributeName = "tv_station")]
        public string Tv_station { get; set; }
        [XmlAttribute(AttributeName = "away_games_back_wildcard")]
        public string Away_games_back_wildcard { get; set; }
    }

    [XmlRoot(ElementName = "games")]
    public class Games
    {
        [XmlElement(ElementName = "game")]
        public List<Game> Game { get; set; }
        [XmlAttribute(AttributeName = "date")]
        public string Date { get; set; }
        [XmlAttribute(AttributeName = "last_modified")]
        public string Last_modified { get; set; }
    }
}