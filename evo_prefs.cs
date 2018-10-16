// ====================================================================
// | EVOLUTION DEFAULT PREFERENCES DO NOT EDIT - FOR INSTRUCTION ONLY |
// ====================================================================

// ****************************
// * MESSAGE OF THE DAY (MOTD)*
// ****************************

// On connect, players can be presented with a message of the day, centerprinted on their screen
// Message of the day (if FFA mode), \n to change line
$Host::EvoMOTD = "Welcome to this T2 server running\nEvolution Admin Mod\nwww.triben.de";

// Lenght of time the MOTD will be visible (in seconds)
$Host::EvoMOTDtime = 10;

// Number of lines in MOTD (max is 3)
$Host::EvoMOTDlines = 3;

// ****************
// * SERVER RULES *
// ****************

// A list of rules for play on the server can be made accessible in
// the Lobby. Tell those O-Snipers you don't want them on your machine.
// Server rules are specified in the array $Host::EvoServerRules[]
// Example:
// $Host::EvoServerRules[1] = "1.) No VPad-Snipers";
// $Host::EvoServerRules[2] = "2.) No Turtling";
// $Host::EvoServerRules[3] = "...";
// etc...

$Host::EvoServerRules[1] = "1.) No VPad-Snipers";
$Host::EvoServerRules[2] = "2.) No Turteling";
$Host::EvoServerRules[3] = "3.) No Multi-Spamm";
$Host::EvoServerRules[4] = "4.) Smurf accounts = BAN";


// ****************
// * MAP ROTATION *
// ****************

// Enable custom map rotation?
// 0 = disabled, 1 = enabled (default)
$Host::EvoCustomMapRotation = 1;

// Custom map rotation file
// Choose only one map rotation file
// $Host::EvoCustomMapRotationFile = "prefs/evo_mapRotation.cs";
$Host::EvoCustomMapRotationFile = "prefs/evo_mapRotation.cs";

// Load the same map ending a tournament mode match?
// 0 = disabled (default), 1 = enabled
$Host::EvoTourneySameMap = 0;

// One map only in FFA?
// 0 = disabled (default), 1 = enabled
$Host::EvoOneMapOnly = 0;


// ****************
// * NO BASE RAPE *
// ****************

// In FFA mode, generators and inventory stations can  automatically be set to an invulnerable state until
// a given number of players is reached. Observers do not count in this consideration.

// Enable No Base Rape option when there aren't too much Players on the server (works only with FFA mode)
// 0 = disabled, 1 = enabled (default)
$Host::EvoNoBaseRapeEnabled = 1;

// Set the number of Players server must reach, to disable No Base Rape (for Classic)
$Host::EvoNoBaseRapeClassicPlayerCount = 16;


// **********
// * SCORES *
// **********

// Show average pings of a team in scorehud
// 0 = disabled, 1 = enabled (default)
$Host::EvoAveragePings = 1;

// Show player scores during debriefing?
// 0 = disabled, 1 = enabled (default)
$Host::ShowEndingPlayerScores = 1;

// Let Players view own score?
// 0 = disabled, 1 = enabled (default)
$Host::ShowIngamePlayerScores = 1;


// *********
// * TEAMS *
// *********

// Enable relaxed fair teams mode (players may change to trailing team)
// 0 = disabled, 1 = enabled (default)
$Host::EvoRelaxedFairTeams = 1;


// ******************
// * VOTE FOR ADMIN *
// ******************

// Minimum number of Players to enable?
$Host::EvoAdminMinPlayers = 5;


// **********************
// * ADMIN RESTRICTIONS *
// **********************

// Allow Admin to vote for mission change and mission time change
// 0 = disabled, 1 = enabled (default)
$Host::EvoForcedVotes = 1;

// Allow Admin to change server password while ingame? (use SADsetpassword("newpw"); or PizzaClient)
// 0 = disabled, 1 = enabled (default)
$Host::EvoAdminServerPW = 1;

// Allow Admin to change max Players while ingame? (need PizzaClient)
// 0 = disabled (default), 1 = enabled
$Host::EvoAdminMaxPlayers = 1;

// Allow Admin to admin other Players if $Host::allowAdminPlayerVotes is 0?
// 0 = disabled, 1 = enabled (default)
$Host::EvoAdminAdmin = 1;

// Allow Admin to ban Players?
// 0 = disabled (default), 1 = enabled
$Host::EvoAdminBan = 0;

// Allow Admin to stop running votes immediately?
// 0 = disabled, 1 = enabled (default)
$Host::EvoAdminStopVotes = 1;

// Allow Admin to pass running votes immediately?
// 0 = disabled, 1 = enabled (default)
$Host::EvoAdminPassVote = 1;

// Allow Admins to view player's info (name, realname, clan, guid, ip address. Need Pizza Client)
// 0 = disabled (default), 1 = enabled
$Host::EvoAdminWhois = 1;

// Allow Admins to reset server?
// 0 = disabled (default), 1 = enabled
$Host::EvoAdminReset = 0;

// Allow Admins to enable/disable CRC check? (server must be started with ispawn or tribes2d-restart.sh!)
// 0 = disabled (default), 1 = enabled
$Host::EvoAdminCRCCheck = 0;

// Allow Admins to enable Clanlock?
// In FFA mode, one team can be locked to be accessible only to members of a given clan. This allows
// semi-public practice. Try your favourite team tactics against a bunch of public players.
// 0 = disabled, 1 = enabled (default)
$Host::EvoAdminClanLock = 1;

// Allow Admins to clear the server for a match?
// Kicks everyone who has no Admin or Super Admin rights
// 0 = disabled (default), 1 = enabled
$Host::EvoAdminClearServer = 0;

// ****************************
// * SUPER ADMIN RESTRICTIONS *
// ****************************

// The Super Admin can do everthing, that an Admin can do, except this extra options !
// -----------------------------------------------------------------------------------

// Allow SuperAdmin to pass running votes immediately?
// 0 = disabled, 1 = enabled (default)
$Host::EvoSuperPassVote = 1;

// Allow SuperAdmins to view player's info? (name, realname, clan, guid, ip address. Need Pizza Client)
// 0 = disabled, 1 = enabled (default)
$Host::EvoSuperAdminWhois = 1;

// Block SuperAdmin's whois information from view
// 0 = disabled (default), 1 = enabled
$Host::EvoBlockSuperAdminWhois = 0;

// Allow SuperAdmins to reset server?
// 0 = disabled, 1 = enabled (default)
$Host::EvoSuperAdminReset = 1;

// Allow SuperAdmins to superadmin other Players?
// 0 = disabled, 1 = enabled (default)
$Host::EvoSuperAdminSuper = 1;

// Allow SuperAdmin to enable/disable CRC check? (server must be started with ispawn or tribes2d-restart.sh!)
// 0 = disabled (default), 1 = enabled
$Host::EvoSuperAdminCRCCheck = 1;

// Allow SuperAdmins to enable Clanlock?
// In FFA mode, one team can be locked to be accessible only to members of a given clan. This allows
// semi-public practice. Tryyour favourite team tactics against a bunch of public players.
// 0 = disabled (default), 1 = enabled
$Host::EvoSuperAdminClanLock = 1;

// Allow SuperAdmins to clear the server for a match?
// Kicks everyone who has no Admin or Super Admin rights
// 0 = disabled, 1 = enabled (default)
$Host::EvoSuperClearServer = 1;


// *************************************
// * LEASED ADMIN / SUPER ADMIN SYSTEM *
// *************************************

// Interval of automatic SA list updates
// 0 = disabled (default), otherwise time in minutes
$Host::EvoLeaseInterval = 0;

// Location of automatic SA list
// Can be either a local filename, or a web address, prefixed with "http://".
// Hostnames with special characters might cause problems. Use IP adress
// instead then.
// Examples:
// $Host::EvoLeaseLocation = "http://130.183.3.130/~jubelgas/timedSA.txt";
// $Host::EvoLeaseLocation = "prefs/leasedSA.txt";
$Host::EvoLeaseLocation = "prefs/leasedSA.txt";

// Default lease level when no specific admin level is specified for a lease,
// using the 1.0 3-value syntax
// 1 = Admin (default), 2 = SuperAdmin
$Host::EvoDefaultLeaseLevel = 1;

// For HTTP accesses, specify this if you need to use a proxy. If left blank,
// no proxy will be used for HTTP accesses.
// Example:
// $Host::EvoHTTPProxy = "my.proxy.com:3130";
$Host::EvoHTTPProxy = "";

// Debug HTTP transfers, displaying every line received on the server console
// 0 = disabled (default), 1 = enabled
// As the HTTP feature is not quite stable yet, this might be a useful switch
// for error detection
$Host::EvoDebugHTTP = 1;

// ****************
// * BAN AND KICK *
// ****************

// Location of Ban List file
$Host::EvoBanListFile = "prefs/evo_BanList.cs";


// *************
// * TEAMKILLS *
// *************

// Number of teamkills for being warned the first time (kick vote warning, 0 to disable)
$Host::EvoTKWarn1 = 3;

// Number of teamkills for starting a vote to kick the player (0 to disable)
$Host::EvoTKVote = 5;

// Number of teamkills for being warned the second time (kick warning, 0 to disable)
$Host::EvoTKWarn2 = 6;

// Number of teamkills for being kicked out of the server (0 to disable)
$Host::EvoTKMax = 8;


// ****************
// * CHAT CONSOLE *
// ****************

// Many of the admin options are accessible without the need of a client download,
// by using the chat commands

// Enable Evolution Chat console
// If chat console is disabled, all chat console commands will be swallowed without
// a response. This is to not accidentially reveal security relevant information.
// A list of console commands can be obtained by typing ".help" in global chat
// 0 = disabled (default), 1 = enabled
$Host::EvoChatConsole = 1;


// *****************
// * AUTO PASSWORD *
// *****************

// If enabled, auto-password will work in tournament mode, but once the password is set, it won't be removed
// 0 = disabled, 1 = enabled (default)
$Host::EvoAutoPWTourneyNoRemove = 1;


// ************************
// * FULL SERVER PASSWORD *
// ************************

// If the maximum number of players on server is reached, it can automatically increase the number of players
// and set a password so that admins can still join

// If enabled, when the server is full, automatically raises the allowed connected Players and set the password
// 0 = disabled, 1 = enabled (default)
$Host::EvoFullServerPWEnabled = 1;

// This is the password that will be set, once the server is full
$Host::EvoFullServerPWPassword = "changeme";

// This is the number of allowed admin the server will add when it's full
$Host::EvoFullServerPWAddAllowed = 4;


// ********
// * VOTE *
// ********

// List of time limits for FFA (these are the times that can be voted)
// Seperate times in minutes by spaces
// Set to "" to use default list
$Host::EvoTimeLimitList = "25 30 45 60 120 150 180 240";

// Reset voted time limits to default on map change?
// 0 = disabled, 1 = enabled (default)
$Host::EvoDefaultTimeLimit = 1;

// At the beginning of a FFA map, players can vote to skip the current map and
// immediately cycle to the next map in the rotation
// Start a vote to skip the current mission on match start?
// 0 = disabled, 1 = enabled (default)
$Host::EvoSkipMission = 1;

// *********************
// * VOTE RESTRICTIONS *
// *********************

// It can easily be configured what votes players have access to. You
// can define whether players are allowed to vote for Change Mission,
// Time Limit, Tournament Mode, Team Damage, Game Type, and how many
// players must be on the server to be able to nominate an Admin by
// vote.

// Allow Players to vote change the mission?
// 0 = disabled, 1 = enabled (default)
$Host::EvoAllowPlayerVoteChangeMission = 1;

// Allow Players to vote change the time limit?
// 0 = disabled, 1 = enabled (default)
$Host::EvoAllowPlayerVoteTimeLimit = 1;

// Allow Players to vote change to tournament mode?
// 0 = disabled, 1 = enabled (default)
$Host::EvoAllowPlayerVoteTournamentMode = 1;

// Allow Players to vote change the team damage?
// 0 = disabled (default), 1 = enabled
$Host::EvoAllowPlayerVoteTeamDamage = 0;

// Allow Players to vote change the game type?
// 0 = disabled, 1 = enabled (default)
$Host::EvoAllowPlayerVoteGameType = 1;

// Allow Admins to vote change the game type?
// 0 = disabled, 1 = enabled (default)
$Host::EvoAllowAdminVoteGameType = 1;

// *******************
// * TOURNAMENT MODE *
// *******************

// Pop up Team Me message when someone join the server, in tournament mode?
// 0 = disabled (default), 1 = enabled
$Host::EvoTeamMeMsg = 1;

// **********************************************************
// * TOURNAMENT MODE CANNED CHAT (VOICE BINDS) RESTRICTIONS *
// **********************************************************

// Allow players to use canned chat (voice binds) on global channel during pre-match phase of tournament mode?
// 0 = disabled, 1 = enabled (default)
$Host::EvoPreMatchCannedSpamAllowed = 1;

// Allow players to use canned chat (voice binds) on global channel during match in tournament mode?
// 0 = disabled, 1 = enabled (default)
$Host::EvoCannedSpamAllowed = 1;

// Allow players to use canned chat (voice binds) on team channel?
// 0 = disabled, 1 = enabled (default)
$Host::EvoTeamCannedSpam = 1;

// *************************************
// * TOURNAMENT MODE CHAT RESTRICTIONS *
// *************************************

// Allow players to chat on global channel during pre-match phase of tournament mode?
// (only global chat, Admin can chat anyway)
// 0 = disabled, 1 = enabled (default)
$Host::EvoPreMatchSpamAllowed = 1;

// Allow players to chat on global channel during match in tournament mode?
// 0 = disabled, 1 = enabled (default)
$Host::EvoSpamAllowed = 1;

// Allow players to chat on team channel during match in tournament mode?
// 0 = disabled, 1 = enabled (default)
$Host::EvoTeamSpam = 1;

// **************
// * STATISTICS *
// **************

// Enable stats?
// 0 = disabled, 1 = enabled (default)
$Host::EvoStats = 1;

// Weapon stats
// 0 = disabled, 1 = kills, 2 = total damage (default)
$Host::EvoStatsType = 2;

// Enable stats in tournament mode? (only if $Host::EvoStats is 1)
// 0 = disabled (default), 1 = enabled
$Host::EvoStatsTourney = 1;

// Show stats during debriefing?
// 0 = disabled, 1 = enabled (default)
$Host::EvoShowStats = 1;

// Where do you want display the stats during the debriefing?
// 0 = before player scores, 1 = after player scores (default)
$Host::EvoStatsPosition = 1;

// *************
// * OBSERVERS *
// *************

// Observers can be automatically kicked after a configurable time to free
// a slot for another player in FFA mode.
// 0 = disabled, > 0 seconds before observer is kicked
$Host::EvoKickObservers = 300;

// Enable Observe Flag mode? ($Host::EvoObserveFlag)
// Using the PizzaClient, observers can choose to observe the flags rather
// than players. No more loosing the focus of action when the flag-carrier
// is killed. You simply stay focused on the flag.
// Setting this variable to 0 allows to deactivate the ObserveFlag feature,
// for policy or compatibility reasons
// 0 = disabled, 1 = enabled (default)
$Host::EvoObserveFlag = 1;

// *****************
// * TOTAL CONTROL *
// *****************

// Evolution contains routines to ease inter-operability with the
// Total Control telnet client. No need to install the custom scripts,
// just enable the feature by setting config variables. This also
// increases privacy of team chat in tournament games, as latter is not
// relayed to the telnet client.

// Chat Messages for Total Control on telnet console
// 0 = disabled, 1 = enabled (default)
$Host::EvoTCMessages = 1;

// Enable display of ingame voice communication in the Total Control Client
// 0 = disabled, 1 = enabled (default)
$Host::EvoTCCannedMessages = 1;

// ***********
// * LOGGING *
// ***********

// Use daily logs? (they will be saved like this: logs/ConnectLog-17-Dec-02.txt)
// 0 = disabled, 1 = enabled (default)
$Host::EvoDailyLogs = 1;

// Starts the new log at this time (use 00-23 hours)
$Host::EvoDailyHour = "00:00";

// Log the ingame chat? (file: logs/Chat/ChatLog.txt)
// 0 = disabled (default), 1 = enabled
$Host::EvoChatLogging = 0;

// Log the ingame voice commands?
// 0 = disabled (default), 1 = enabled
$Host::EvoCannedChatLogging = 0;

// Log what Admins and SuperAdmins do? (file: logs/Admin/AdminLog.txt)
// 0 = disabled, 1 = enabled (default)
$Host::EvoAdminLogging = 1;

// Log client info on connect? (realname, tag, guid and ip address. File: logs/Connect/ConnectLog.txt)
// 0 = disabled, 1 = enabled (default)
$Host::EvoConnectLogging = 1;

// Log Teamkills? (file: logs/TK/TKLog.txt)
// 0 = disabled (default), 1 = enabled
$Host::EvoTKLogging = 0;

// ******************
// * DEFENSE TURRET *
// ******************

// Set to 1 to enable DT or 0 to disable DT.
// 0 = disabled, 1 = enabled (default)
$Host::DefenseTurret::Active = 1;

// Set to 1 to make DT optional on a server, or 0 to require it in FFA.
// Clients without DefenseTurret will receive an advertisement message to install
// DefenseTurret. When set to 0, clients HAVE to have DefenseTurret installed or
// they will not be allowed on the server.
// 0 = disabled (default), 1 = enabled
$Host::DefenseTurret::Optional = 0;
	
// Set to 1 to require DT in Tourney mode, or 0 to be optional
// This variable is really only used in the dtAdmin code to determine whether
// to require clients in Tournament mode, or not.
// 0 = disabled, 1 = enabled (default)
$Host::DefenseTurret::RequiredInTourney = 1;
	
// This variable sets the maximum allowable height of a client created waypoint.
// The default is 10 metres. The height is calculated from the closest object on the
// ground to the requested waypoint. If this height is exceeded, the client is penalised
// by having all waypoints reset, and waypointing capabilities disabled for a period
// of 6 seconds, after which the client may create new waypoints again.
// Effectively this boils down to a server admin having the option to allow QFireMission
// style spam or not. Setting the max height to something like 1000 metres will give
// you all the spam you want.
$Host::DefenseTurret::MaxWptHeight = 10;

// ***********************
// *       EXTRAS        *
// ***********************

//Server Host
$Host::HostedBy = "Branzone";
//Server Github
$Host::Github = "https://github.com/Server";
//Server Discord
$Host::Discord = "https://www.discordapp.com/";
