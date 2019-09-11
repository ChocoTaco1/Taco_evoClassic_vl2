// chatLog(%client, %msg, %team)
// Info: Logs the ingame chat
function chatLog(%client, %msg, %team)
{
   if(!%client.isAiControlled())
   {
      // type of the message: team or global
      if(%team)
         %type = "[TEAM]";
      else
         %type = "[GLOBAL]";

      // get client info
      %authInfo = %client.getAuthInfo();

      // this is the message that will be logged
      $ChatLog = formatTimeString("d-M-yy") SPC formatTimeString("[HH:nn]") SPC %client.nameBase @ " (" @ getField(%authInfo, 0) @ ", " @ getField(%authInfo, 1) @ ", " @ %client.guid @ ", " @ %client.getAddress() @ ")" SPC %type @ ": " @ %msg;

      // log the message
      if($Host::EvoDailyLogs)
      {
         if(formatTimeString("HH") > getSubStr($Host::EvoDailyHour, 0, strstr($Host::EvoDailyHour, ":")) || (formatTimeString("HH") == getSubStr($Host::EvoDailyHour, 0, strstr($Host::EvoDailyHour, ":")) && formatTimeString("nn") >= getSubStr($Host::EvoDailyHour, strstr($Host::EvoDailyHour, ":") + 1, 2)))
            export("$ChatLog", "logs/Chat/ChatLog-" @ formatTimeString("d-M-yy") @ ".txt", true);
         else
         {
            %yesterday = formatTimeString("d") - 1;
            export("$ChatLog", "logs/Chat/ChatLog-" @ %yesterday @ formatTimeString("-M-yy") @ ".txt", true);
         }
      }
      else
         export("$ChatLog", "logs/Chat/ChatLog.txt", true);
   }
}

// adminLog(%client, %msg)
// Info: Logs the admin events
function adminLog(%client, %msg)
{
   if(%client.isAdmin && $Host::EvoAdminLogging)
   {
      // get the client info
      %authInfo = %client.getAuthInfo();

      // this is the info that will be logged
      $AdminLog = formatTimeString("d-M-yy") SPC formatTimeString("[HH:nn]") SPC %client.nameBase @ " (" @ getField(%authInfo, 0) @ ", " @ getField(%authInfo, 1) @ ", " @ %client.guid @ ", " @ %client.getAddress() @ ")" @ %msg;

      // log the action
      if($Host::EvoDailyLogs)
      {
         if(formatTimeString("HH") > getSubStr($Host::EvoDailyHour, 0, strstr($Host::EvoDailyHour, ":")) || (formatTimeString("HH") == getSubStr($Host::EvoDailyHour, 0, strstr($Host::EvoDailyHour, ":")) && formatTimeString("nn") >= getSubStr($Host::EvoDailyHour, strstr($Host::EvoDailyHour, ":")+1, 2)))
            export("$AdminLog", "logs/Admin/AdminLog-" @ formatTimeString("d-M-yy") @ ".txt", true);
         else
         {
            %yesterday = formatTimeString("d") - 1;
            export("$AdminLog", "logs/Admin/AdminLog-" @ %yesterday @ formatTimeString("-M-yy") @ ".txt", true);
         }
      }
      else
         export("$AdminLog", "logs/Admin/AdminLog.txt", true);
   }
}

// connectLog(%client, %realname, %tag)
// Info: Logs the connections
function connectLog(%client)
{
   if($Host::EvoConnectLogging)
   {
      // get the client info
      %authInfo = %client.getAuthInfo();

      // net tournament client present?
	  if (!%client.t2csri_sentComCertDone)
		%ntc = 0;
	  else
		%ntc = 1;
	
	  // connect info
	  %ConnectLogPlayerCount = $HostGamePlayerCount;
	  $ConnectLog = formatTimeString("d-M-yy") SPC formatTimeString("[HH:nn]") SPC %client.nameBase SPC "(" @ getField(%authInfo, 0) @ "," SPC %client.guid @ "," SPC %client.getAddress() @ ")" SPC "Pop[" @ %ConnectLogPlayerCount @ "]" SPC "Map[" @ $CurrentMission @ "]" SPC "NTC[" @ %ntc @ "]";

      // log the message
      if($Host::EvoDailyLogs)
      {
         if(formatTimeString("HH") > getSubStr($Host::EvoDailyHour, 0, strstr($Host::EvoDailyHour, ":")) || (formatTimeString("HH") == getSubStr($Host::EvoDailyHour, 0, strstr($Host::EvoDailyHour, ":")) && formatTimeString("nn") >= getSubStr($Host::EvoDailyHour, strstr($Host::EvoDailyHour, ":")+1, 2)))
            export("$ConnectLog", "logs/Connect/ConnectLog-" @ formatTimeString("d-M-yy") @ ".txt", true);
         else
         {
            %yesterday = formatTimeString("d") - 1;
            export("$ConnectLog", "logs/Connect/ConnectLog-" @ %yesterday @ formatTimeString("-M-yy") @ ".txt", true);
         }
      }
      else
         export("$ConnectLog", "logs/Connect/ConnectLog.txt", true);
   }
}