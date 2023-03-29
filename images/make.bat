REM deps: http://www.imagemagick.org and https://inkscape.org

REM add to path
set PATH=%PATH%;C:\Program Files\Inkscape\bin;D:\bin\ImageMagick

REM EMF uncomment if you want this
set catalog=svg\Catalogus.svg
set batch=svg\Bestand.svg
set adres=svg\Adres.svg
set setting=svg\Settings.svg
set poi=svg\POI.svg
set place=svg\Place.svg
set parcel=svg\Perceel.svg
set info=svg\Info.svg
set hoogte=svg\Hoogte.svg
set gipod=svg\Gipod.svg

REM png's
inkscape %adres%   -w 16 -h 16 -o geopuntAddress16x16.png
inkscape %catalog% -w 16 -h 16 -o geopuntCatalog16x16.png
inkscape %parcel%  -w 16 -h 16 -o geopuntPerceel16x16.png
inkscape %batch%   -w 16 -h 16 -o geopuntBatch16x16.png
inkscape %hoogte%  -w 16 -h 16 -o geopuntElevation16x16.png
inkscape %gipod%   -w 16 -h 16 -o geopuntGipod16x16.png
inkscape %poi%     -w 16 -h 16 -o geopuntPoi16x16.png
inkscape %place%   -w 16 -h 16 -o geopuntReverse16x16.png
inkscape %setting% -w 16 -h 16 -o geopuntSetting16x16.png
inkscape %info%    -w 16 -h 16 -o geopuntAbout16x16.png

inkscape %adres%   -w 24 -h 24 -o geopuntAddress24x24.png
inkscape %catalog% -w 24 -h 24 -o geopuntCatalog24x24.png
inkscape %parcel%  -w 24 -h 24 -o geopuntPerceel24x24.png
inkscape %batch%   -w 24 -h 24 -o geopuntBatch24x24.png
inkscape %hoogte%  -w 24 -h 24 -o geopuntElevation24x24.png
inkscape %gipod%   -w 24 -h 24 -o geopuntGipod24x24.png
inkscape %poi%     -w 24 -h 24 -o geopuntPoi24x24.png
inkscape %place%   -w 24 -h 24 -o geopuntReverse24x24.png
inkscape %setting% -w 24 -h 24 -o geopuntSetting24x24.png
inkscape %info%    -w 24 -h 24 -o geopuntAbout24x24.png

inkscape %adres%   -w 32 -h 32 -o geopuntAddress32x32.png
inkscape %catalog% -w 32 -h 32 -o geopuntCatalog32x32.png
inkscape %parcel%  -w 32 -h 32 -o geopuntPerceel32x32.png
inkscape %batch%   -w 32 -h 32 -o geopuntBatch32x32.png
inkscape %hoogte%  -w 32 -h 32 -o geopuntElevation32x32.png
inkscape %gipod%   -w 32 -h 32 -o geopuntGipod32x32.png
inkscape %poi%     -w 32 -h 32 -o geopuntPoi32x32.png
inkscape %place%   -w 32 -h 32 -o geopuntReverse32x32.png
inkscape %setting% -w 32 -h 32 -o geopuntSetting32x32.png
inkscape %info%    -w 32 -h 32 -o geopuntAbout32x32.png

inkscape %adres%   -w 48 -h 48 -o geopuntAddress48x48.png
inkscape %catalog% -w 48 -h 48 -o geopuntCatalog48x48.png
inkscape %parcel%  -w 48 -h 48 -o geopuntPerceel48x48.png
inkscape %batch%   -w 48 -h 48 -o geopuntBatch48x48.png
inkscape %hoogte%  -w 48 -h 48 -o geopuntElevation48x48.png
inkscape %gipod%   -w 48 -h 48 -o geopuntGipod48x48.png
inkscape %poi%     -w 48 -h 48 -o geopuntPoi48x48.png
inkscape %place%   -w 48 -h 48 -o geopuntReverse48x48.png
inkscape %setting% -w 48 -h 48 -o geopuntSetting48x48.png
inkscape %info%    -w 48 -h 48 -o geopuntAbout48x48.png

inkscape %adres%   -w 256 -h 256 -o geopuntAddress256x256.png
inkscape %catalog% -w 256 -h 256 -o geopuntCatalog256x256.png
inkscape %parcel%  -w 256 -h 256 -o geopuntPerceel256x256.png
inkscape %batch%   -w 256 -h 256 -o geopuntBatch256x256.png
inkscape %hoogte%  -w 256 -h 256 -o geopuntElevation256x256.png
inkscape %gipod%   -w 256 -h 256 -o geopuntGipod256x256.png
inkscape %poi%     -w 256 -h 256 -o geopuntPoi256x256.png
inkscape %place%   -w 256 -h 256 -o geopuntReverse256x256.png
inkscape %setting% -w 256 -h 256 -o geopuntSetting256x256.png
inkscape %info%    -w 256 -h 256 -o geopuntAbout256x256.png

REM icon's for forms
magick convert -background none geopuntAddress32x32.png geopuntAddress48x48.png geopuntAddress256x256.png geopuntAddress.ico
magick convert -background none geopuntCatalog32x32.png geopuntCatalog48x48.png geopuntCatalog256x256.png geopuntCatalog.ico
magick convert -background none geopuntPerceel32x32.png geopuntPerceel48x48.png geopuntPerceel256x256.png geopuntPerceel.ico
magick convert -background none geopuntBatch32x32.png geopuntBatch48x48.png geopuntBatch256x256.png geopuntBatch.ico
magick convert -background none geopuntElevation32x32.png geopuntElevation48x48.png geopuntElevation256x256.png geopuntElevation.ico
magick convert -background none geopuntGipod32x32.png geopuntGipod48x48.png geopuntGipod256x256.png geopuntGipod.ico
magick convert -background none geopuntPoi32x32.png geopuntPoi48x48.png geopuntPoi256x256.png geopuntPoi.ico
magick convert -background none geopuntReverse32x32.png geopuntReverse48x48.png geopuntReverse256x256.png geopuntReverse.ico
magick convert -background none geopuntSetting32x32.png geopuntSetting48x48.png geopuntSetting256x256.png geopuntSetting.ico
magick convert -background none geopuntAbout32x32.png geopuntAbout48x48.png geopuntAbout256x256.png  geopuntAbout.ico

REM copy to manual
copy /Y geopuntAddress24x24.png ..\man\geopuntAddressCmd.png
copy /Y geopuntCatalog24x24.png ..\man\geopuntDataCatalogusCmd.png
copy /Y geopuntPerceel24x24.png ..\man\geopuntPerceelCmd.png
copy /Y geopuntBatch24x24.png ..\man\geopuntBatchGeocodingCmd.png
copy /Y geopuntElevation24x24.png ..\man\geopuntElevationCmd.png
copy /Y geopuntGipod24x24.png ..\man\geopuntGipodCmd.png
copy /Y geopuntPoi24x24.png ..\man\geopuntPoiCmd.png
copy /Y geopuntReverse24x24.png ..\man\geopuntReverseCmd.png
copy /Y geopuntSetting24x24.png ..\man\geopuntSettingCmd.png
copy /Y geopuntAbout24x24.png ..\man\geopuntAboutCmd.png

REM copy to addincontent
copy /Y geopuntAddress32x32.png ..\geopunt4arcgis\Images\geopuntAddressCmd.png
copy /Y geopuntCatalog32x32.png ..\geopunt4arcgis\Images\geopuntDataCatalogusCmd.png
copy /Y geopuntPerceel32x32.png ..\geopunt4arcgis\Images\geopuntPerceelCmd.png
copy /Y geopuntBatch32x32.png ..\geopunt4arcgis\Images\geopuntBatchGeocodingCmd.png
copy /Y geopuntElevation32x32.png ..\geopunt4arcgis\Images\geopuntElevationCmd.png
copy /Y geopuntGipod32x32.png ..\geopunt4arcgis\Images\geopuntGipodCmd.png
copy /Y geopuntPoi32x32.png ..\geopunt4arcgis\Images\geopuntPoiCmd.png
copy /Y geopuntReverse32x32.png ..\geopunt4arcgis\Images\geopuntReverseCmd.png
copy /Y geopuntSetting32x32.png ..\geopunt4arcgis\Images\geopuntSettingCmd.png
copy /Y geopuntAbout32x32.png ..\geopunt4arcgis\Images\geopuntAboutCmd.png