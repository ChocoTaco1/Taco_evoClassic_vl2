function PizzaTriconPopup(%client, %key, %text, %function, %number)
{
   if ( %client.pizza )
   {
      messageClient( %client, 'MsgPlayerPopupItem', "", %key, %function, "",  %text, %number );
      return;
   }
   if ( %client.tricon )
   {
      messageClient( %client, 'MsgPlayerPopupItem', "", %key, %function, "", %text, 10000+%number );
      return;
   }
}

function TriconWrapper(%client, %target, %function)
{
   switch(%function)
   {
      case 10016:
         serverCmdWhois( %client, %target );
         return 1;

      case 10017:
         serverCmdAddToBanList( %client, %target );
         return 1;

      case 10019:
         serverCmdSuperAdminPlayer( %client, %target );
         return 1;
   }
   return 0;
}

// END VOTE MENU ITEMS

// GENERAL STUFF

// cmdAutoKickObserver(%client)
// Info: Will kick the player if he/she is still in observer.
function cmdAutoKickObserver(%client, %key) // Edit GG
{
   if (($Host::TournamentMode) || (!$MissionRunning) || (%client.isAdmin) || (%client.team != 0) || (!%client.okkey) || (%client.okkey != %key))
      return;

   %client.okkey = "";
   if( isObject( %client.player ) )
      %client.player.scriptKill(0);

   if ( isObject( %client ) )
   {
      messageAll('MsgAdminForce', '\c2%1 has left the game. (Observer Timeout)', %client.nameBase);

      %client.setDisconnectReason( "Observer Timeout" );
      %client.schedule(700, "delete");
   }
}

// PERMANENT BAN FUNCTIONS

// serverCmdAddToBanList(%client, %target)
// Info: Add the player to the ban list
//function serverCmdAddToBanList(%client, %target)
//{
//   if(%client.isSuperAdmin || (%client.isAdmin && $Host::EvoAdminPermanentBan))
//   {
//      // an admin can not be banned
//      if(%target.isAdmin)
//      {
//         messageClient(%client, '', 'You can\'t ban an admin!');
//         return;
//      }
//      if(%target.guid $= "")
//         return;
//
//      // get infos of the player to kick
//      %authInfo = %target.getAuthInfo();
//      %banRowCount = 0;
//
//      // read the file
//      %read = new fileObject();
//      %read.openForRead( $Host::EvoBanListFile );
//      while(!%read.isEOF())
//         %banRow[%banRowCount++] = %read.readLine();
//
//      %read.close();
//      %read.delete();
//
//      // append the new line to the file
//      %write = new fileObject();
//      %write.openForWrite( $Host::EvoBanListFile );
//      for(%x = 1; %x <= %banRowCount; %x++)
//         %write.writeLine(%banRow[%x]);
//
//      %write.writeLine("$EvoBanPlayer[$EvoBanPlayerCount++] = \"" @ getField(%authInfo, 0) SPC %target.guid @ "\";");
//      %write.close();
//      %write.delete();
//
//      // exec the new file (so server can load the new variables)
//      exec( $Host::EvoBanListFile );
//
//      // ban the target
//      ban(%target, %client);
//      adminLog(%client, " banned " @ %target.nameBase @ " (" @ getField(%authInfo, 0) @ ", " @ getField(%authInfo, 1) @ ", " @ %target.guid @ ", " @ %target.getAddress() @ ")");
//   }
//}

// serverCmdAddClanToBanList(%client, %target)
// Info: Add the player's clan to the ban list
function serverCmdAddClanToBanList(%client, %target)
{
   if(%client.isSuperAdmin || (%client.isAdmin && $Host::EvoAdminPermanentBan))
   {
      // an admin can not be banned
      if(%target.isAdmin)
      {
         messageClient(%client, '', 'You can\'t ban an admin!');
         return;
      }
      // get infos of the player to kick
      %authInfo = %target.getAuthInfo();
      if(getField(%authInfo, 1) $= "")
         return;

      %banRowCount = 0;

      // read the file
      %read = new fileObject();
      %read.openForRead( $Host::EvoBanListFile );
      while(!%read.isEOF())
         %banRow[%banRowCount++] = %read.readLine();

      %read.close();
      %read.delete();

      // append the new line to the file
      %write = new fileObject();
      %write.openForWrite( $Host::EvoBanListFile );
      for(%x = 1; %x <= %banRowCount; %x++)
         %write.writeLine(%banRow[%x]);

      %write.writeLine("$EvoBanClan[$EvoBanClanCount++] = \"" @ getField(%authInfo, 1) @ "\";");
      %write.close();
      %write.delete();

      // exec the new file (so server can load the new variables)
      exec( $Host::EvoBanListFile );

      // ban the target
      ban(%target, %client);
      adminLog(%client, " banned " @ %target.nameBase @ " (" @ getField(%authInfo, 0) @ ", " @ getField(%authInfo, 1) @ ", " @ %target.guid @ ", " @ %target.getAddress() @ ")");
   }
}

// handleSendBanList()
// Info: Send all the players/clans banned to the admin
function handleSendBanList(%client)
{
   // send banned players
   for(%x = 0; %x <= $EvoBanPlayerCount; %x++)
   {
      if($EvoBanPlayer[%x] !$= "")
         messageClient(%client, 'MsgPizzaNameBanItem', "", %x, $EvoBanPlayer[%x]);
   }

   // send banned clans
   for(%i = 0; %i <= $EvoBanClanCount; %i++)
   {
      if($EvoBanClan[%i] !$= "")
         messageClient(%client, 'MsgPizzaClanBanItem', "", %i, $EvoBanClan[%i]);
   }
}

// serverCmdGetPizzaBanList(%client)
// Info: Send Admins the ban list
function serverCmdGetPizzaBanList(%client)
{
   if(%client.isSuperAdmin || (%client.isAdmin && $Host::EvoAdminPermanentBan))
      handleSendBanList(%client);
}

// serverCmdPizzaRemoveBan(%client, %id, %text)
// Info: Remove a ban from the list
function serverCmdPizzaRemoveBan(%client, %id, %text)
{
   if(%client.isSuperAdmin || (%client.isAdmin && $Host::EvoAdminPermanentBan))
   {
      // be sure that they're valid variables
      if(%id $= "" || %text $= "")
         return;

      // be sure that they're valid variables
      if(($EvoBanPlayer[%id] !$= %text) && ($EvoBanClan[%id] !$= %text))
         return;

      %banRowCount = 0;

      // read the file until we find the one to remove
      %read = new fileObject();
      %read.openForRead( $Host::EvoBanListFile );
      while(!%read.isEOF())
      {
         %banRow[%banRowCount++] = %read.readLine();
         if(strstr(%banRow[%banRowCount], %text) != -1)
            %lineRow = %banRowCount; // found
      }
      %read.close();
      %read.delete();

      // rewrite the file without the line to remove
      %write = new fileObject();
      %write.openForWrite( $Host::EvoBanListFile );
      for(%x = 1; %x <= %banRowCount; %x++)
      {
         if(%x != %lineRow)
            %write.writeLine(%banRow[%x]);
      }
      %write.close();
      %write.delete();

      // refresh the variables
      deleteVariables("$EvoBan*");

      deleteFile( $Host::EvoBanListFile @ ".dso" );
      exec( $Host::EvoBanListFile );

      // this will cleanup the client's hud
      messageClient(%client, 'MsgPizzaBanCleanUp', "");

      // fill the updated ban list
      handleSendBanList(%client);
   }
}