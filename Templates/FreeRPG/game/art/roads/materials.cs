//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

singleton Material(DefaultDecalRoadMaterial)
{
   diffuseMap[0] = "art/roads/defaultRoadTextureTop.png";
   mapTo = "unmapped_mat";
   materialTag0 = "RoadAndPath";
};

singleton Material(DefaultRoadMaterialTop)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/roads/defaultRoadTextureTop.png";
   materialTag0 = "RoadAndPath";
};

singleton Material(DefaultRoadMaterialOther)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/roads/defaultRoadTextureOther.png";
   materialTag0 = "RoadAndPath";
};

singleton Material(road_sand_dds)
{
//   bumpTex[0] = "sand_road_normal_specular.png";

   translucent = true;
   mapTo = "sand_road_diffuse_transparency.dds";
   diffuseMap[0] = "art/roads/sand_road_diffuse_transparency.dds";
   translucentZWrite = "1";
   normalMap[0] = "art/roads/sand_road_normal.dds";
   materialTag0 = "RoadAndPath";
   pixelSpecular[0] = "0";
   specularMap[0] = "art/roads/sand_road_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   castShadows = "1";
   materialTag1 = "RoadAndPath";
//   translucentBlendOp = none;
//   translucentZWrite = true;
//   alphaTest = true;

//   pixelSpecular = true;
//   specular = "1 1 1 0"; // 1 1 0 0 = pure yellow
//   specularPower = 12;
};

singleton Material(road_wetmud)
{
   baseTex[0] = "";
//   bumpTex[0] = "sand_road_normal_specular.dds";

   translucent = true;
   mapTo = "mud_road_diffuse_transparency.dds";
   diffuseMap[0] = "mud_road_diffuse_transparency.dds";
   materialTag0 = "RoadAndPath";
   normalMap[0] = "wetmud_road_normal_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   specular[0] = "1 1 1 0";
   specularPower[0] = "12";
   pixelSpecular[0] = "1";
   translucentBlendOp = "None";
   translucentZWrite = "1";
   alphaTest = "1";
//   translucentBlendOp = none;
//   translucentZWrite = true;
//   alphaTest = true;

//   pixelSpecular = true;
//   specular = "1 1 1 0"; // 1 1 0 0 = pure yellow
//   specularPower = 12;
};

singleton Material(road_wetmud)
{
   baseTex[0] = "";
   bumpTex[0] = "";

   translucent = true;
   translucentBlendOp = none;
   translucentZWrite = true;
   alphaTest = true;

   pixelSpecular = true;
   specular = "1 1 1 0"; // 1 1 0 0 = pure yellow
   specularPower = 12;
   mapTo = "mud_road_diffuse_transparency.dds";
   diffuseMap[0] = "mud_road_diffuse_transparency.dds";
   normalMap[0] = "wetmud_road_normal_specular.dds";
   materialTag0 = "RoadAndPath";
};




singleton Material( ShoreDebrisMaterial )
{
   baseTex[0] = "";
   mapTo = "shore_debris.png";
   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = true;
   alphaTest = true; 
   alphaRef = 75;
   diffuseMap[0] = "art/roads/shore_debris.dds";
   materialTag0 = "RoadAndPath";
   normalMap[0] = "art/roads/shore_debris_nrm.dds";
   specularPower[0] = "1";
   materialTag1 = "Vegetation";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
};


singleton Material( OceanWave01Material )
{
   baseTex[0] = "";
   mapTo = "Ocean_Wave_01.png";
   translucent = 1;
   translucentBlendOp = Sub;
   translucentZWrite = 1;
   alphaTest = 0; 
   alphaRef = 1;
   diffuseMap[0] = "art/roads/Ocean_Wave_01.dds";
   materialTag0 = "RoadAndPath";
   normalMap[0] = "art/roads/Ocean_Wave_01_nrm.dds";
   specularPower[0] = "1";
   diffuseMap[1] = "art/roads/Ocean_Wave_02.dds";
   normalMap[1] = "art/roads/Ocean_Wave_02_nrm.dds";
   animFlags[0] = "0x00000005";
   animFlags[1] = "0x00000005";
   scrollDir[0] = "0.4 0.1";
   scrollDir[1] = "-0.4 -0.1";
   scrollSpeed[0] = "0";
   scrollSpeed[1] = "0.4";
   waveFreq[0] = "0.15";
   waveFreq[1] = "0.15";
   waveAmp[0] = "0.25";
   waveAmp[1] = "0.25";
   diffuseMap[2] = "art/roads/Ocean_Wave_02.dds";
   normalMap[2] = "art/roads/Ocean_Wave_02_nrm.dds";
   animFlags[2] = "0x00000005";
   scrollDir[2] = "-0.4 -0.25";
   scrollSpeed[2] = "0.4";
   waveFreq[2] = "0.15";
   waveAmp[2] = "0.25";
   castShadows = "0";
   subSurfaceRolloff[0] = "0.2";
   rotSpeed[0] = "0";
   rotPivotOffset[0] = "0 0";
   detailNormalMap[2] = "";
   diffuseMap[3] = "art/roads/Ocean_Wave_01.dds";
   normalMap[3] = "art/roads/Ocean_Wave_01_nrm.dds";
   animFlags[3] = "0x00000005";
   scrollDir[3] = "0.4 0.25";
   scrollSpeed[3] = "0.4";
   waveFreq[3] = "0.15";
   waveAmp[3] = "0.25";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   specularPower[1] = "1";
   specularPower[2] = "1";
   specularPower[3] = "1";
   detailScale[0] = "8 8";
   detailNormalMap[0] = "art/terrains/dirty sand/dirtysand_normal_displacement.png";
   detailNormalMapStrength[0] = "0";
};


singleton Material( OceanWave02Material )
{
   baseTex[0] = "";
   mapTo = "Ocean_Wave_02.png";
   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = true;
   alphaTest = true; 
   alphaRef = 75;
   diffuseMap[0] = "art/roads/Ocean_Wave_02.png";
   materialTag0 = "RoadAndPath";
   normalMap[0] = "art/roads/shore_debris_nrm.dds";
   specularPower[0] = "1";
};


singleton Material(dirt_trail)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/roads/dirt_trail_dif.dds";
   translucent = "1";
   materialTag0 = "RoadAndPath";
   translucentZWrite = "1";
   alphaRef = "27";
   castShadows = "0";
   backlight = "1";
   materialTag2 = "decal";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   materialTag1 = "RoadAndPath";
   detailScale[0] = "50 50";
   detailNormalMapStrength[0] = "0.8";
   specularPower[0] = "1";
};
