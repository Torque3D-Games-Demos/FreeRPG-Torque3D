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

singleton Material(DECAL_scorch)
{
   baseTex[0] = "./scorch_decal.png";

   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 84;
};

singleton Material(DECAL_RocketEXP)
{
   baseTex[0] = "art/decals/rBlast";

   vertColor[0] = true;
   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = true;
};

singleton Material(DECAL_bulletHole)
{
   baseTex[0] = "art/decals/Bullet Holes/BulletHole_Walls.dds";

   vertColor[0] = true;
   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = true;
};

singleton Material(DECAL_defaultblobshadow)
{
   baseTex[0] = "art/decals/defaultblobshadow";

   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = true;
   alphaTest = false;
   //alphaRef = 64;
   //emissive[0] = "1";
};

singleton Material(DECAL_leavesdebris)
{

//   pixelSpecular = true;
//   specular = "1 1 1 0"; // 1 1 0 0 = pure yellow
//   specularPower = 12;

   translucent = true;
   translucentBlendOp = None;
   translucentZWrite = true;
   alphaTest = true;
   alphaRef = 30;
   mapTo = "leavesdebris_diffuse_transparency.png";
   diffuseMap[0] = "art/decals/leaves_debris/leavesdebris_diffuse_transparency.png";
   normalMap[0] = "art/decals/leaves_debris/leavesdebris_normal_specular.png";
   materialTag0 = "decal";
   vertColor[0] = "1";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
};


singleton Material(DECAL_moss)
{
   baseTex[0] = "";
   bumpTex[0] = "";

//   pixelSpecular = true;
//   specular = "1 1 1 0"; // 1 1 0 0 = pure yellow
//   specularPower = 12;

   translucent = true;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = true;
   alphaTest = 0;
   alphaRef = 84;
   mapTo = "moss_diffuse_transparency.png";
   diffuseMap[0] = "art/decals/moss/moss_diffuse_transparency.dds";
   normalMap[0] = "art/decals/moss/moss_normal.dds";
   materialTag0 = "decal";
   castShadows = "0";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   specularPower[0] = "1";
   specularMap[0] = "art/decals/moss/moss_specular.dds";
   vertColor[0] = "1";
};





singleton Material(DECAL_wornearth)
{
   baseTex[0] = "";
//   bumpTex[0] = "./shore_debris/shoredebris_normal_specular.png";

//   pixelSpecular = true;
//   specular = "1 1 1 0"; // 1 1 0 0 = pure yellow
//   specularPower = 12;

   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "sedimentary.png";
   diffuseMap[0] = "art/decals/worn_earth/wornearth_diffuse_transparency.dds";
   materialTag0 = "decal";
   normalMap[0] = "art/decals/worn_earth/wornearth_normal_specularity.dds";
   specularPower[0] = "1";
   pixelSpecular[0] = "1";

   useAnisotropic[0] = true;
   specularMap[0] = "art/decals/worn_earth/wornearth_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   vertColor[0] = "1";
};



singleton Material(DECAL_exposedrock)
{
   diffuseMap[0] = "art/decals/exposed_rock/exposedrock_diffuse_transparency.dds";
   normalMap[0] = "art/decals/exposed_rock/exposedrock_normals_specularity.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "sedimentary.png";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "0";

   useAnisotropic[0] = true;
   specularMap[0] = "art/decals/exposed_rock/exposedrock_specular.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   vertColor[0] = "1";
};

singleton Material(DECAL_beachdebris01)
{
   diffuseMap[0] = "art/decals/beach_debris/beachdebris_01_diffuse_transparency.dds";
   normalMap[0] = "beachdebris_01_normals.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "sedimentary.png";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "1";

   useAnisotropic[0] = true;
   vertColor[0] = "1";
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
};



singleton Material(DECAL_shorerock01)
{
   diffuseMap[0] = "art/decals/shore_rock/seaweed_rock_dif.dds";
   normalMap[0] = "art/decals/shore_rock/seaweed_rock_nrm.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "sedimentary.png";

   materialTag0 = "decal";
   specularPower[0] = "71";
   pixelSpecular[0] = "0";

   useAnisotropic[0] = true;
   specularMap[0] = "art/decals/shore_rock/seaweed_rock_spc.dds";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   backlight = "1";
   vertColor[0] = "1";
};




singleton Material(DECAL_seaweed01)
{
   diffuseMap[0] = "art/decals/seaweed/seaweed_01_dif.dds";
   normalMap[0] = "art/decals/seaweed/seaweed_01_nrm.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "sedimentary.png";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "1";

   useAnisotropic[0] = true;
   vertColor[0] = "1";
};

singleton Material(DECAL_cliffcover01)
{
   diffuseMap[0] = "art/decals/cliffcover/cliff_cover_dif.dds";
   normalMap[0] = "art/decals/cliffcover/cliff_cover_nrm.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "sedimentary.png";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "0";

   useAnisotropic[0] = true;
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   vertColor[0] = "1";
};

singleton Material(DECAL_volcanowall01)
{
   diffuseMap[0] = "art/decals/volcano_wall/volcano_wall_dif.dds";
   normalMap[0] = "art/decals/volcano_wall/volcano_wall_nrm.dds";


   translucent = 1;
   translucentBlendOp = LerpAlpha;
   translucentZWrite = 1;
   alphaTest = 0;
   alphaRef = 1;
   mapTo = "sedimentary.png";

   materialTag0 = "decal";
   specularPower[0] = "91";
   pixelSpecular[0] = "0";

   useAnisotropic[0] = true;
   backlight = "1";
   backLightFactor = "0.9 1.0 0.2";
   forestWindEnabled = "1";
   vertColor[0] = "1";
};

singleton Material(DECAL_rockface_one_transparency)
{
   mapTo = "rockface_one_diffuse_transparency";
   diffuseMap[0] = "../red.png";
   normalMap[0] = "../red.png";
   translucent = "1";
   materialTag0 = "decal";
};


singleton Material(DecalDirtTrail)
{
   mapTo = "unmapped_mat";
   diffuseMap[0] = "art/decals/dirt_trail_end/dirt_trail_end_dif.dds";
   castShadows = "0";
   translucent = "1";
   translucentZWrite = "1";
   materialTag0 = "decal";
};
