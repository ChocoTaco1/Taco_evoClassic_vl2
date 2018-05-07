$EvoVersion = "1.2.3c";

// getPlayerHeight(%player, %distance)
// date: 19/09/2002
// Info: Calculate player's height.
// Changed name so it will not conflicht with
// other definitions from different MOD's.
function EvoGetPlayerHeight(%player, %distance)
{
  %posFrom = getWords( %player.getTransform(), 0, 2 );
  %posTo = VectorAdd( %posFrom, "0 0 -10000" );
  %hit1 = getWords( containerRayCast( %posFrom, %posTo, 
                  ( $TypeMasks::TerrainObjectType | $TypeMasks::StaticShapeObjectType | 
                    $TypeMasks::InteriorObjectType ), 0), 1, 3);

  if ( VectorDist( %posFrom, %hit1 ) > ( %distance ) )
    return 1;

  return 0;
}

// deleteDso()
// Info: Delete dso (usefull for switching mod)
function deleteDso()
{
   %cnt = 0;
   %tmpObj = new ScriptObject() {};
   for(%file = findFirstFile("*.dso"); %file !$= ""; %file = findNextFile("*.dso"))
      %tmpObj.file[%cnt++] = %file;

   for(%i=0; %i<%cnt; %i++)
      deleteFile(%tmpObj.file[%i]);

   %tmpObj.delete();
}

// checkMapExist(%missionName, %missionType)
// Info: check if a map exist in the mission type
function checkMapExist(%missionName, %missionType)
{
	// Find if the mission exists
   for(%mis = 0; %mis < $HostMissionCount; %mis++)
       if($HostMissionFile[%mis] $= %missionName)
           break;

   // Now find if the mission type exists
   for(%type = 0; %type < $HostTypeCount; %type++)
       if($HostTypeName[%type] $= %missionType)
           break;

   // Now find if the mission's index in the mission-type specific sub-list exists
   for(%i = 0; %i < $HostMissionCount[%type]; %i++)
       if($HostMission[%type, %i] == %mis)
           break;

	if($HostMission[%type, %i] !$= "")
		return true; // valid map
   else
   	return false; // invalid map
}

//  EvoFindTarget( %param )
//  Info: Find a player name/ID matching %param
function EvoFindTarget( %param )
{
  %param = strlwr( %param );

    for (%i = 0; %i < ClientGroup.getCount(); %i++)
    {
        %target = ClientGroup.getObject(%i);

	if ( ( %target == %param ) || 
	     ( $PlayingOnline && ( %target.guid == %param ) )
	     )
	  // Most trivial check: Does the name match the GUID or Client ID ?
	  {
	    return %target;
	  }

	if ( getTaggedString(%target.name) $= %param || 
       strlwr(%target.nameBase ) $= %param )
	  // If the name we get like this matches, then it's fine
	  {
	    return %target;
	  }
    }

    return -1;
}

function EvoHex ( %value )
{
   %HexDigits = "0123456789ABCDEF";
   %value = %value % 256;
   %HexString = getSubStr( %HexDigits, %value / 16, 1 );
   %HexString = %HexString @ getSubStr ( %HexDigits, %value % 16, 1 );
   return %HexString;
}

function HSLColor ( %h, %s, %l )
{
 if ( %l <= 0.5 )
  {
    %v = ( %l * ( 1.0 + %s ) );
  }
  else
  {
    %v = ( %l + %s - %l * %s );
  }

  if ( %v <= 0.0 )
  {
    %r = 0.0;
    %g = 0.0;
    %b = 0.0;
  }
  else
  {
    %m = %l + %l - %v;
    %sv = ( %v - %m ) / %v;

    %h = 6.0 * %h;

    %sextant = mfloor( %h );

    %fract = %h - %sextant;
    %vsf   = %v * %sv * %fract;

    %mid1 = %m + %vsf;
    %mid2 = %v - %vsf;

    switch ( %sextant )
    {
      case 0:
        %r = %v;
        %g = %mid1;
        %b = %m;

      case 1:
        %r = %mid2;
        %g = %v;
        %b = %mid1;

      case 2:
        %r = %m;
        %g = %v;
        %b = %mid1;

      case 3:
        %r = %m;
        %g = %mid2;
        %b = %v;

      case 4:
        %r = %mid1;
        %g = %m;
        %b = %v;

      case 5:
        %r = %v;
        %g = %m;
        %b = %mid2;

    }
  }

  %r = mfloor ( 255.0 * %r );
  %g = mfloor ( 255.0 * %g );
  %b = mfloor ( 255.0 * %b );

  return "<color:"@ EvoHex( %r ) @ EvoHex( %g ) @ EvoHex( %b ) @ ">";
}

// function IsClientInClan
// Info: Checks whether certain client is member of clan %clan, using
//       all available getAuthInfo information
function EvoIsClientInClan ( %client, %clan )
{
  %TrimmedClan = trim( %clan );

  %AuthInfo = %client.getAuthInfo();

  %AuthField = 6;
  %ThisClan = getField( %AuthInfo, %AuthField );

  while ( %ThisClan !$= "" )
    {
      if ( %TrimmedClan $= trim ( %ThisClan ) )
	return 1;

      %AuthField += 6;
      %ThisClan = getField( %AuthInfo, %AuthField );
    }

  return 0;
}

function EvoSetTempTeamName( %team, %string )
{
   if ( $Evo::ThisMission::TeamName[ %team ] )
      removeTaggedString( $Evo::ThisMission::TeamName[%team] );

   $Evo::ThisMission::TeamName[ %team ] = addTaggedString( %string );
}

function EvoRemoveTempTeamName( %team )
{
   if ( $Evo::ThisMission::TeamName[ %team ] )
      removeTaggedString( $Evo::ThisMission::TeamName[%team] );

   $Evo::ThisMission::TeamName[%team]="";
}

function EvoPlayersOnTeamCount()
{
    return $TotalTeamPlayerCount;
}
