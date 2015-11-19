SET workDir=%cd%
SET SRC_PATH=%~dp0
echo %SRC_PATH%

cd /d %SRC_PATH%

CALL dnvm use default
CALL dnx --watch web 

cd /d %workDir%