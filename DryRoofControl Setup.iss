; Script generated by the Inno Script Studio Wizard.
; SEE THE DOCUMENTATION FOR DETAILS ON CREATING INNO SETUP SCRIPT FILES!

#define MyAppName "DryRoofControl"
#define MyAppVersion "1.2.1.0"
#define MyAppPublisher "Cedric Raguenaud"
#define MyAppURL "https://github.com/cedric-r/DryRoofControl"
#define MyAppExeName "DryRoofControl.exe"

[Setup]
; NOTE: The value of AppId uniquely identifies this application.
; Do not use the same AppId value in installers for other applications.
; (To generate a new GUID, click Tools | Generate GUID inside the IDE.)
AppId={{716A3DF9-DD7B-4DF8-AF74-8F77F68F4BD7}
AppName={#MyAppName}
AppVersion={#MyAppVersion}
;AppVerName={#MyAppName} {#MyAppVersion}
AppPublisher={#MyAppPublisher}
AppPublisherURL={#MyAppURL}
AppSupportURL={#MyAppURL}
AppUpdatesURL={#MyAppURL}
DefaultDirName={pf}\{#MyAppName}
DefaultGroupName={#MyAppName}
LicenseFile=K:\astro\DryRoofControl\LICENSE
OutputDir="."
OutputBaseFilename=DryRoofControl Setup
Compression=lzma
SolidCompression=yes

[Languages]
Name: "english"; MessagesFile: "compiler:Default.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\DryRoofControl.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Astrometry.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Astrometry.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Attributes.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Attributes.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Controls.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Controls.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.DeviceInterfaces.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.DeviceInterfaces.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.DriverAccess.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.DriverAccess.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Exceptions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Exceptions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Internal.Extensions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Internal.Extensions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.SettingsProvider.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.SettingsProvider.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Utilities.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Utilities.Video.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\ASCOM.Utilities.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\DryRoofControl.exe"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\DryRoofControl.exe.config"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\System.Configuration.ConfigurationManager.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\System.Configuration.ConfigurationManager.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\System.Security.AccessControl.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\System.Security.AccessControl.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\System.Security.Permissions.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\System.Security.Permissions.xml"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\System.Security.Principal.Windows.dll"; DestDir: "{app}"; Flags: ignoreversion
Source: "K:\astro\DryRoofControl\DryRoofControl\bin\Debug\System.Security.Principal.Windows.xml"; DestDir: "{app}"; Flags: ignoreversion
; NOTE: Don't use "Flags: ignoreversion" on any shared system files

[Icons]
Name: "{group}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon

[Run]
Filename: "{app}\{#MyAppExeName}"; Description: "{cm:LaunchProgram,{#StringChange(MyAppName, '&', '&&')}}"; Flags: nowait postinstall skipifsilent
