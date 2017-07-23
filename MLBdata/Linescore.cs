using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Ballgame
{
    [XmlRoot(ElementName = "review")]
    public class Review
    {
        [XmlAttribute(AttributeName = "challenges_away_used")]
        public string Challenges_away_used { get; set; }
        [XmlAttribute(AttributeName = "challenges_away_remaining")]
        public string Challenges_away_remaining { get; set; }
        [XmlAttribute(AttributeName = "challenges_home_used")]
        public string Challenges_home_used { get; set; }
        [XmlAttribute(AttributeName = "challenges_home_remaining")]
        public string Challenges_home_remaining { get; set; }
    }

    [XmlRoot(ElementName = "linescore")]
    public class LinescoreInning
    {
        [XmlAttribute(AttributeName = "inning")]
        public string Inning { get; set; }
        [XmlAttribute(AttributeName = "home_inning_runs")]
        public string Home_inning_runs { get; set; }
        [XmlAttribute(AttributeName = "away_inning_runs")]
        public string Away_inning_runs { get; set; }
    }

    [XmlRoot(ElementName = "current_batter")]
    public class Current_batter
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
        [XmlAttribute(AttributeName = "avg")]
        public string Avg { get; set; }
    }

    [XmlRoot(ElementName = "current_pitcher")]
    public class Current_pitcher
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "first")]
        public string First { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
        [XmlAttribute(AttributeName = "last")]
        public string Last { get; set; }
        [XmlAttribute(AttributeName = "name_display_roster")]
        public string Name_display_roster { get; set; }
        [XmlAttribute(AttributeName = "wins")]
        public string Wins { get; set; }
        [XmlAttribute(AttributeName = "losses")]
        public string Losses { get; set; }
        [XmlAttribute(AttributeName = "era")]
        public string Era { get; set; }
        [XmlAttribute(AttributeName = "s_wins")]
        public string S_wins { get; set; }
        [XmlAttribute(AttributeName = "s_losses")]
        public string S_losses { get; set; }
        [XmlAttribute(AttributeName = "s_era")]
        public string S_era { get; set; }
    }

    [XmlRoot(ElementName = "current_ondeck")]
    public class Current_ondeck
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
    }

    [XmlRoot(ElementName = "current_inhole")]
    public class Current_inhole
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
    }

    [XmlRoot(ElementName = "due_up_batter")]
    public class Due_up_batter
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
    }

    [XmlRoot(ElementName = "due_up_ondeck")]
    public class Due_up_ondeck
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
    }

    [XmlRoot(ElementName = "due_up_inhole")]
    public class Due_up_inhole
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
    }

    [XmlRoot(ElementName = "opposing_pitcher")]
    public class Opposing_pitcher
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "first")]
        public string First { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
        [XmlAttribute(AttributeName = "last")]
        public string Last { get; set; }
        [XmlAttribute(AttributeName = "name_display_roster")]
        public string Name_display_roster { get; set; }
        [XmlAttribute(AttributeName = "wins")]
        public string Wins { get; set; }
        [XmlAttribute(AttributeName = "losses")]
        public string Losses { get; set; }
        [XmlAttribute(AttributeName = "era")]
        public string Era { get; set; }
        [XmlAttribute(AttributeName = "s_wins")]
        public string S_wins { get; set; }
        [XmlAttribute(AttributeName = "s_losses")]
        public string S_losses { get; set; }
        [XmlAttribute(AttributeName = "s_era")]
        public string S_era { get; set; }
    }

    [XmlRoot(ElementName = "media")]
    public class LinescoreMedia
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
    }

    [XmlRoot(ElementName = "game_media")]
    public class LinescoreGame_media
    {
        [XmlElement(ElementName = "media")]
        public Media Media { get; set; }
    }

    [XmlRoot(ElementName = "game")]
    public class LinescoreGame
    {
        [XmlElement(ElementName = "review")]
        public Review Review { get; set; }
        [XmlElement(ElementName = "linescore")]
        public List<LinescoreInning> Linescore { get; set; }
        [XmlElement(ElementName = "current_batter")]
        public Current_batter Current_batter { get; set; }
        [XmlElement(ElementName = "current_pitcher")]
        public Current_pitcher Current_pitcher { get; set; }
        [XmlElement(ElementName = "current_ondeck")]
        public Current_ondeck Current_ondeck { get; set; }
        [XmlElement(ElementName = "current_inhole")]
        public Current_inhole Current_inhole { get; set; }
        [XmlElement(ElementName = "due_up_batter")]
        public Due_up_batter Due_up_batter { get; set; }
        [XmlElement(ElementName = "due_up_ondeck")]
        public Due_up_ondeck Due_up_ondeck { get; set; }
        [XmlElement(ElementName = "due_up_inhole")]
        public Due_up_inhole Due_up_inhole { get; set; }
        [XmlElement(ElementName = "opposing_pitcher")]
        public Opposing_pitcher Opposing_pitcher { get; set; }
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
        [XmlAttribute(AttributeName = "first_pitch_et")]
        public string First_pitch_et { get; set; }
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
        [XmlAttribute(AttributeName = "venue_w_chan_loc")]
        public string Venue_w_chan_loc { get; set; }
        [XmlAttribute(AttributeName = "location")]
        public string Location { get; set; }
        [XmlAttribute(AttributeName = "gameday_link")]
        public string Gameday_link { get; set; }
        [XmlAttribute(AttributeName = "away_win")]
        public string Away_win { get; set; }
        [XmlAttribute(AttributeName = "away_games_back")]
        public string Away_games_back { get; set; }
        [XmlAttribute(AttributeName = "away_loss")]
        public string Away_loss { get; set; }
        [XmlAttribute(AttributeName = "home_games_back")]
        public string Home_games_back { get; set; }
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
        [XmlAttribute(AttributeName = "inning_state")]
        public string Inning_state { get; set; }
        [XmlAttribute(AttributeName = "note")]
        public string Note { get; set; }
        [XmlAttribute(AttributeName = "status")]
        public string Status { get; set; }
        [XmlAttribute(AttributeName = "ind")]
        public string Ind { get; set; }
        [XmlAttribute(AttributeName = "is_perfect_game")]
        public string Is_perfect_game { get; set; }
        [XmlAttribute(AttributeName = "is_no_hitter")]
        public string Is_no_hitter { get; set; }
        [XmlAttribute(AttributeName = "inning")]
        public string Inning { get; set; }
        [XmlAttribute(AttributeName = "balls")]
        public string Balls { get; set; }
        [XmlAttribute(AttributeName = "strikes")]
        public string Strikes { get; set; }
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
        [XmlAttribute(AttributeName = "pbp_last")]
        public string Pbp_last { get; set; }
        [XmlAttribute(AttributeName = "runner_on_base_status")]
        public string Runner_on_base_status { get; set; }
        [XmlAttribute(AttributeName = "runner_on_1b")]
        public string Runner_on_1b { get; set; }
        [XmlAttribute(AttributeName = "runner_on_2b")]
        public string Runner_on_2b { get; set; }
        [XmlAttribute(AttributeName = "runner_on_3b")]
        public string Runner_on_3b { get; set; }
        [XmlAttribute(AttributeName = "mlbtv_link")]
        public string Mlbtv_link { get; set; }
        [XmlAttribute(AttributeName = "home_audio_link")]
        public string Home_audio_link { get; set; }
        [XmlAttribute(AttributeName = "away_audio_link")]
        public string Away_audio_link { get; set; }
        [XmlAttribute(AttributeName = "tv_station")]
        public string Tv_station { get; set; }
        [XmlElement(ElementName = "winning_pitcher")]
        public Winning_pitcher winning_pitcher { get; set; }
        [XmlElement(ElementName = "losing_pitcher")]
        public Losing_pitcher losing_pitcher { get; set; }
        [XmlElement(ElementName = "save_pitcher")]
        public Save_pitcher save_pitcher { get; set; }

    }
    [XmlRoot(ElementName = "winning_pitcher")]
    public class Winning_pitcher
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "first")]
        public string First { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
        [XmlAttribute(AttributeName = "last")]
        public string Last { get; set; }
        [XmlAttribute(AttributeName = "name_display_roster")]
        public string Name_display_roster { get; set; }
        [XmlAttribute(AttributeName = "wins")]
        public string Wins { get; set; }
        [XmlAttribute(AttributeName = "losses")]
        public string Losses { get; set; }
        [XmlAttribute(AttributeName = "era")]
        public string Era { get; set; }
        [XmlAttribute(AttributeName = "s_wins")]
        public string S_wins { get; set; }
        [XmlAttribute(AttributeName = "s_losses")]
        public string S_losses { get; set; }
        [XmlAttribute(AttributeName = "s_era")]
        public string S_era { get; set; }
    }

    [XmlRoot(ElementName = "losing_pitcher")]
    public class Losing_pitcher
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "first")]
        public string First { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
        [XmlAttribute(AttributeName = "last")]
        public string Last { get; set; }
        [XmlAttribute(AttributeName = "name_display_roster")]
        public string Name_display_roster { get; set; }
        [XmlAttribute(AttributeName = "wins")]
        public string Wins { get; set; }
        [XmlAttribute(AttributeName = "losses")]
        public string Losses { get; set; }
        [XmlAttribute(AttributeName = "era")]
        public string Era { get; set; }
        [XmlAttribute(AttributeName = "s_wins")]
        public string S_wins { get; set; }
        [XmlAttribute(AttributeName = "s_losses")]
        public string S_losses { get; set; }
        [XmlAttribute(AttributeName = "s_era")]
        public string S_era { get; set; }
    }

    [XmlRoot(ElementName = "save_pitcher")]
    public class Save_pitcher
    {
        [XmlAttribute(AttributeName = "first_name")]
        public string First_name { get; set; }
        [XmlAttribute(AttributeName = "first")]
        public string First { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
        [XmlAttribute(AttributeName = "last_name")]
        public string Last_name { get; set; }
        [XmlAttribute(AttributeName = "last")]
        public string Last { get; set; }
        [XmlAttribute(AttributeName = "name_display_roster")]
        public string Name_display_roster { get; set; }
        [XmlAttribute(AttributeName = "wins")]
        public string Wins { get; set; }
        [XmlAttribute(AttributeName = "losses")]
        public string Losses { get; set; }
        [XmlAttribute(AttributeName = "era")]
        public string Era { get; set; }
        [XmlAttribute(AttributeName = "s_wins")]
        public string S_wins { get; set; }
        [XmlAttribute(AttributeName = "s_losses")]
        public string S_losses { get; set; }
        [XmlAttribute(AttributeName = "s_era")]
        public string S_era { get; set; }
        [XmlAttribute(AttributeName = "saves")]
        public string Saves { get; set; }
    }
}