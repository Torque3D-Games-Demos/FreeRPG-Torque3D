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

new TerrainMaterial()
{
   normalMap = "art/terrains/grass/grass_sparse_mossy_normal";
   detailMap = "art/terrains/grass/grass_sparse_mossy_detail";
   internalName = "grass_sparse_mossy";
   diffuseSize = "200";
   diffuseMap = "art/terrains/grass/grass_sparse_mossy_base";
   detailDistance = "150";
   parallaxScale = "0.07";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/sand/sand_small_waves_base";
   normalMap = "art/terrains/sand/sand_small_waves_normal";
   detailMap = "art/terrains/sand/sand_small_waves_detail";
   internalName = "sand_small_waves";
   diffuseSize = "100";
   parallaxScale = "0.1";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/soil/soil_rough_base";
   diffuseSize = "200";
   normalMap = "art/terrains/soil/soil_rough_normal";
   detailMap = "art/terrains/soil/soil_rough_detail";
   detailDistance = "150";
   parallaxScale = "0.1";
   internalName = "soil_rough";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/gravel/gravel_ground_colorful_base";
   diffuseSize = "100";
   normalMap = "art/terrains/gravel/gravel_ground_colorful_normal";
   detailMap = "art/terrains/gravel/gravel_ground_colorful_detail";
   detailDistance = "150";
   parallaxScale = "0.06";
   internalName = "gravel_ground_colorful";
   detailStrength = "1.2";
};


new TerrainMaterial()
{
   diffuseMap = "art/terrains/soil/soil_gravel_base";
   diffuseSize = "200";
   normalMap = "art/terrains/soil/soil_gravel_normal";
   detailMap = "art/terrains/soil/soil_gravel_detail";
   detailDistance = "150";
   parallaxScale = "0.07";
   internalName = "soil_gravel";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/soil/soil_bigstones_base";
   diffuseSize = "50";
   normalMap = "art/terrains/soil/soil_bigstones_normal";
   detailMap = "art/terrains/soil/soil_bigstones_detail";
   detailDistance = "150";
   parallaxScale = "0.1";
   internalName = "soil_bigstones";
   detailStrength = "1.2";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/soil/soil_rough_base";
   diffuseSize = "200";
   normalMap = "art/terrains/grass/grass_sparse_mossy_normal";
   detailMap = "art/terrains/grass/grass_sparse_mossy_detail";
   detailDistance = "150";
   parallaxScale = "0.08";
   internalName = "grass_sparse_mossy_soil_base";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/sand/sand_rough_base";
   diffuseSize = "200";
   normalMap = "art/terrains/sand/sand_rough_normal";
   detailMap = "art/terrains/sand/sand_rough_detail";
   detailSize = "5";
   detailDistance = "150";
   parallaxScale = "0.07";
   internalName = "sand_rough";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/rock/rock_brown_cracks_base";
   diffuseSize = "150";
   normalMap = "art/terrains/rock/rock_brown_cracks_normal";
   detailMap = "art/terrains/rock/rock_brown_cracks_detail";
   detailDistance = "150";
   parallaxScale = "0.05";
   internalName = "rock_brown_cracks";
   detailSize = "10";
   useSideProjection = "0";
   detailStrength = "1";
   macroSize = "50";
   macroStrength = "2";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/rock/rock_brown_cracks_base";
   diffuseSize = "150";
   normalMap = "art/terrains/rock/rock_brown_cracks_normal";
   detailMap = "art/terrains/rock/rock_brown_cracks_detail";
   detailSize = "15";
   detailDistance = "150";
   useSideProjection = "1";
   parallaxScale = "0";
   internalName = "rock_brown_cracks_side";
   detailStrength = "1";
};


new TerrainMaterial()
{
   diffuseMap = "art/terrains/grass/grass_sparse_mossy_base";
   diffuseSize = "200";
   normalMap = "art/terrains/grass/grass_lush_soft_normal";
   detailMap = "art/terrains/grass/grass_lush_soft_detail";
   detailDistance = "150";
   parallaxScale = "0.1";
   internalName = "grass_lush_soft_gsm_base";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/grass/grass_mixed_medium_base";
   diffuseSize = "100";
   normalMap = "art/terrains/grass/grass_mixed_medium_normal";
   detailMap = "art/terrains/grass/grass_mixed_medium_detail";
   detailDistance = "100";
   parallaxScale = "0.05";
   internalName = "grass_mixed_medium";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/grass/grass_lush_soft_base";
   diffuseSize = "200";
   normalMap = "art/terrains/grass/grass_lush_soft_normal";
   detailMap = "art/terrains/grass/grass_lush_soft_detail";
   detailDistance = "150";
   parallaxScale = "0.1";
   internalName = "grass_lush_soft";
   detailSize = "5";
};


new TerrainMaterial()
{
   diffuseMap = "art/terrains/rock/rock_rough_mossy_base";
   normalMap = "art/terrains/rock/rock_rough_mossy_normal";
   detailMap = "art/terrains/rock/rock_rough_mossy_detail";
   internalName = "newMaterial";
   detailSize = "10";
   detailDistance = "150";
   useSideProjection = "1";
   parallaxScale = "0.08";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/rock/rock_rough_mossy_base";
   diffuseSize = "250";
   normalMap = "art/terrains/rock/rock_rough_mossy_normal";
   detailMap = "art/terrains/rock/rock_rough_mossy_detail";
   detailSize = "15";
   detailDistance = "150";
   useSideProjection = "1";
   internalName = "rock_rough_ mossy_side";
   detailStrength = "1.2";
};
// ----------------------------------------------------------------------------
// Sample grass
// ----------------------------------------------------------------------------

singleton Material(TerrainFX_grass1)
{
   mapTo = "grass1";
   footstepSoundId = 0;
   terrainMaterials = "1";
   ShowDust = "1";
   showFootprints = "1";
   materialTag0 = "Terrain";
   effectColor[0] = "0.42 0.42 0 1";
   effectColor[1] = "0.42 0.42 0 1";
   impactSoundId = "0";
};

new TerrainMaterial()
{
   internalName = "grass1";
   diffuseMap = "art/terrains/Example/grass1";
   detailMap = "art/terrains/Example/grass1_d";
   detailSize = "10";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "200";
};

singleton Material(TerrainFX_grass2)
{
   mapTo = "grass2";
   footstepSoundId = 0;
   terrainMaterials = "1";
   ShowDust = "1";
   showFootprints = "1";
   materialTag0 = "Terrain";
   effectColor[0] = "0.42 0.42 0 1";
   effectColor[1] = "0.42 0.42 0 1";
   impactSoundId = "0";
};

new TerrainMaterial()
{
   internalName = "grass2";
   diffuseMap = "art/terrains/Example/grass2";
   detailMap = "art/terrains/Example/grass2_d";
   detailSize = "10";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "200";
};

singleton Material(TerrainFX_grass1dry)
{
   mapTo = "grass1_dry";
   footstepSoundId = 0;
   terrainMaterials = "1";
   ShowDust = "1";
   showFootprints = "1";
   materialTag0 = "Terrain";
   effectColor[0] = "0.63 0.55 0 1";
};

new TerrainMaterial()
{
   internalName = "grass1_dry";
   diffuseMap = "art/terrains/Example/grass1_dry";
   detailMap = "art/terrains/Example/grass1_dry_d";
   detailSize = "10";
   detailDistance = "100";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "250";
   detailStrength = "2";
};

singleton Material(TerrainFX_dirt_grass)
{
   mapTo = "dirt_grass";
   footstepSoundId = 0;
   terrainMaterials = "1";
   ShowDust = "1";
   showFootprints = "1";
   materialTag0 = "Terrain";
   effectColor[0] = "0.63 0.55 0 1";
};

new TerrainMaterial()
{
   internalName = "dirt_grass";
   diffuseMap = "art/terrains/Example/dirt_grass";
   detailMap = "art/terrains/Example/dirt_grass_d";
   detailSize = "5";
   detailDistance = "100";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "200";
};

// ----------------------------------------------------------------------------
// Sample rock
// ----------------------------------------------------------------------------

singleton Material(TerrainFX_rocktest)
{
   mapTo = "rocktest";
   footstepSoundId = "1";
   terrainMaterials = "1";
   ShowDust = "1";
   showFootprints = "1";
   materialTag0 = "Terrain";
   impactSoundId = "1";
   effectColor[0] = "0.25 0.25 0.25 1";
   effectColor[1] = "0.25 0.25 0.25 0";
};

new TerrainMaterial()
{
   internalName = "rocktest";
   diffuseMap = "art/terrains/Example/rocktest";
   detailMap = "art/terrains/Example/rocktest_d";
   detailSize = "10";
   detailDistance = "100";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "400";
};

// ----------------------------------------------------------------------------
// Sample rock
// ----------------------------------------------------------------------------


new TerrainMaterial()
{
   internalName = "stone";
   diffuseMap = "art/terrains/Example/stone";
   detailMap = "art/terrains/Example/stone_d";
   detailSize = "10";
   detailDistance = "100";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "400";
   useSideProjection = "0";
};
// ----------------------------------------------------------------------------
// Sample sand
// ----------------------------------------------------------------------------

singleton Material(TerrainFX_sand)
{
   mapTo = "sand";
   footstepSoundId = "3";
   terrainMaterials = "1";
   ShowDust = "1";
   showFootprints = "1";
   materialTag0 = "Terrain";
   specularPower[0] = "1";
   effectColor[0] = "0.84 0.71 0.5 1";
   effectColor[1] = "0.84 0.71 0.5 0.349";
};

new TerrainMaterial()
{
   internalName = "sand";
   diffuseMap = "art/terrains/Example/sand";
   detailMap = "art/terrains/Example/sand_d";
   detailSize = "10";
   detailDistance = "100";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "200";
};

singleton SFXDescription(FootStepDesc : AudioEffect )
{
   isLooping         = false;
   is3D              = true;
   ReferenceDistance = 1.0;
   MaxDistance       = 5;
};

singleton SFXProfile(Grass_Step_Sound)
{
   filename    = "art/sound/grassstepsingle";
   description = FootStepDesc;
   preload = true;
};

singleton SFXProfile(Dirt_Step_Sound)
{
   filename    = "art/sound/dirtstep.ogg";
   description = FootStepDesc;
   preload = true;
};

singleton SFXProfile(Sand_Step_Sound)
{
   filename    = "art/sound/sandstep";
   description = FootStepDesc;
   preload = true;
};


new TerrainMaterial() 
{
   internalName = "warning_material";
   diffuseMap = "core/art/warnMat.png";
   detailMap = "core/art/warnMat.png";
   detailScale = 128;
};




//TerrainTest_Gray2 Terrain

new TerrainMaterial()
{
   internalName = "TerrainTest_Gray2";
   diffuseMap = "art/terrains/grid/elieworld_margin";
   diffuseSize = "318";
   detailMap = "art/terrains/grid/512_grey";
   detailDistance = "2000";
};

//WetSand Terrain

new TerrainMaterial()
{
   internalName = "WetSand";
   diffuseMap = "art/terrains/wet sand/wetsand_base";
   normalMap = "art/terrains/wet sand/wetsand_normal";
   detailMap = "art/terrains/wet sand/wetsand_detail";
   detailScale = "512";
   detailSize = "2";
   detailDistance = "100";
};

singleton Material( Terrain_SFX_Sand_Mat )
{
   mapTo = "wetsand_base";
   customFootstepSound = Sand_Step_Sound;
};

//DirtySand Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/dirty sand/dirtysand_base";
   diffuseSize = "900";
   normalMap = "art/terrains/dirty sand/dirtysand_2_nrm";
   detailMap = "art/terrains/dirty sand/dirtysand_detail";
   detailSize = "2";
   detailStrength = "0.8";
   detailDistance = "100";
   parallaxScale = "0.02";
   internalName = "DirtySand";
   detailScale = "512";
};

singleton Material( Terrain_SFX_DirtySand_Mat )
{
   mapTo = "dirtysand_base";
   customFootstepSound = Sand_Step_Sound;
};


//DirtySand Terrain 2

new TerrainMaterial()
{
   diffuseMap = "art/terrains/dirty sand/dirtysand_base";
   normalMap = "art/terrains/dirty sand/dirtysand_2_nrm";
   detailMap = "art/terrains/dirty sand/dirtysand_2_detail";
   detailSize = "2";
   detailStrength = "0.7";
   detailDistance = "100";
   parallaxScale = "0.02";
   internalName = "DirtySand2";
   detailScale = "512";
   diffuseSize = "900";
};

/*
singleton Material( Terrain_SFX_DirtySand_Mat )
{
   mapTo = "dirtysand_base";
   customFootstepSound = Sand_Step_Sound;
};
*/

//DirtSandMix Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/dirty sand/dirtyandmix_base";
   diffuseSize = "500";
   normalMap = "art/terrains/dirty sand/dirtsandmix_nrm";
   detailMap = "art/terrains/dirty sand/dirtsandmix_detail";
   detailSize = "2";
   detailStrength = "0.7";
   detailDistance = "100";
   parallaxScale = "0.02";
   internalName = "DirtSandMix";
   detailScale = "512";
};

/*
singleton Material( Terrain_SFX_DirtySand_Mat )
{
   mapTo = "dirtsandmix_base";
   customFootstepSound = Sand_Step_Sound;
};
*/

//RockyDirt Terrain

new TerrainMaterial()
{
   internalName = "RockyDirt";
   diffuseMap = "art/terrains/rocky dirt/rockydirt_base";
   normalMap = "art/terrains/rocky dirt/rockydirt_normal";
   detailMap = "art/terrains/rocky dirt/rockydirt_detail";
   detailScale = "512";
   detailSize = "4.4";
   parallaxScale = "0";
   detailDistance = "500";
   detailStrength = "1";
};
singleton Material( Terrain_SFX_RockyDirt_Mat )
{
   mapTo = "rockydirt_base";
   customFootstepSound = Dirt_Step_Sound;
};

//RockyDirtDark Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/rocky dirt/rockydirt_base";
   normalMap = "art/terrains/rocky dirt/rockydirt_normal";
   detailMap = "art/terrains/rocky dirt/rockydirt_detail";
   internalName = "RockyDirtDark";
   detailSize = "3.5";
   detailDistance = "1000";
   detailStrength = "0.5";
};

//Grass Terrain

new TerrainMaterial()
{
   internalName = "Grass";
   diffuseMap = "art/terrains/base grass/grass_base";
   normalMap = "art/terrains/base grass/grass_normal";
   detailMap = "art/terrains/base grass/grass_detail";
   detailScale = "512";
   detailSize = "2";
   detailDistance = "200";
   detailStrength = "1";
};


singleton Material( Terrain_SFX_Grass_Mat )
{
   mapTo = "grass_base2";
   customFootstepSound = Grass_Step_Sound;
};

//RiverRock Terrain

new TerrainMaterial()
{
   internalName = "RiverRock";
   diffuseMap = "art/terrains/grayrock/grayrock_base";
   normalMap = "art/terrains/ocean rocks/oceanrocks_normal";
   detailMap = "art/terrains/ocean rocks/oceanrocks_detail";
   detailScale = "256";
   detailStrength = "0.5";
   parallaxScale = "0.03";
   detailSize = "4";
};

singleton Material( Terrain_SFX_RiverRock_Mat )
{
   mapTo = "grayrock_base";
   customFootstepSound = Dirt_Step_Sound;
};

//RockGroundWithGrassTerrain

new TerrainMaterial()
{
   internalName = "RockGroundWithGrass";
   diffuseMap = "art/terrains/rocky ground with grass/rockygroundwithgrass_base";
   normalMap = "art/terrains/rocky ground with grass/rockygroundwithgrass_normal_displacement";
   detailMap = "art/terrains/rocky ground with grass/rockygroundwithgrass_detail";
   detailScale = "256";
   detailDistance = "1000";
   parallaxScale = "0";
};

singleton Material( Terrain_SFX_RockGroundWithGrass_Mat )
{
   mapTo = "rockygroundwithgrass_base";
   customFootstepSound = Dirt_Step_Sound;
};

// GrayRockNear Terrain


new TerrainMaterial()
{
   internalName = "GrayRockNear";
   diffuseMap = "art/terrains/grayrock/rockfromabovebrown";
   detailMap = "art/terrains/grayrock/grayrock_detail";   
   detailSize = "5";
   isManaged = "1";
   detailBrightness = "1";
   Enabled = "1";
   diffuseSize = "128";
   normalMap = "art/terrains/grayrock/grayrock_normal_specular";
   detailDistance = "1000";
   parallaxScale = "0.05";
   useSideProjection = "1";
};


//Grayrockfar Terrain


new TerrainMaterial()
{
   diffuseMap = "art/terrains/grayrock/rockfromabovebrown";
   diffuseSize = "400";
   normalMap = "art/terrains/grayrock/grayrock_normal_specular";
   detailMap = "art/terrains/grayrock/grayrock_detail";
   detailSize = "20";
   detailDistance = "2000";
   useSideProjection = "1";
   internalName = "GrayRockFar";
};

singleton Material( Terrain_SFX_GrayRockFar_Mat )
{
   mapTo = "rockfromabovebrown";
   customFootstepSound = Dirt_Step_Sound;
};

//VolcanoRock Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/volcanic_mix/tex_volcanic_rock_base";
   normalMap = "art/terrains/volcanic_mix/tex_volcanic_rock_nrm";
   detailMap = "art/terrains/volcanic_mix/tex_volcanic_rock_dif";
   detailStrength = "1.4";
   detailDistance = "1000";
   internalName = "VolcanoRock";
   enabled = "1";
   isManaged = "1";
   detailBrightness = "1";
   diffuseSize = "80";
};


// VolcanicSplash Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/volcanic_mix/tex_volcanic_rock_base";
   normalMap = "art/terrains/volcanic_mix/tex_volcanic_rock_nrm";
   detailMap = "art/terrains/volcanic_mix/tex_volcanic_rock_burn_dif";
   detailSize = "10";
   detailStrength = "1.2";
   detailDistance = "500";
   internalName = "VolcanicSplash";
   diffuseSize = "40";
};

// VolcanicCliffRockTop Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/volcanic_mix/tex_volcanic_cliffrock_base";
   diffuseSize = "200";
   normalMap = "art/terrains/volcanic_mix/tex_volcanic_cliffrock_nrm";
   detailMap = "art/terrains/volcanic_mix/tex_volcanic_cliffrock_dif";
   detailSize = "8";
   detailStrength = "0.4";
   detailDistance = "1000";
   internalName = "VolcanicCliffRockTop";
};

// VolcanicCliffSide Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/volcanic_mix/tex_volcanic_cliffrock_base";
   normalMap = "art/terrains/volcanic_mix/tex_volcanic_cliffrock_nrm";
   detailMap = "art/terrains/volcanic_mix/tex_volcanic_cliffrock_dif";
   detailSize = "14";
   detailDistance = "1000";
   useSideProjection = "1";
   internalName = "VolcanicCliffSide";
   diffuseSize = "500";
   detailStrength = "0.5";
};

//SeaweedMain Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/seaweed/Seaweed_base";
   normalMap = "art/terrains/seaweed/Seaweed_nrm_displacement";
   detailMap = "art/terrains/seaweed/Seaweed_detail";
   detailSize = "5.5";
   detailStrength = "0.4";
   detailDistance = "1000";
   parallaxScale = "0.03";
   internalName = "SeaweedMain";
};

//SeaweedRiverRock Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/seaweed/Seaweed_base";
   normalMap = "art/terrains/ocean rocks/oceanrocks_normal";
   detailMap = "art/terrains/ocean rocks/oceanrocks_dif";
   parallaxScale = "0.03";
   internalName = "SeaweedRiverRock";
   detailSize = "4";
   detailDistance = "50";
   detailStrength = "0.5";
};

// RockySeaweed Terrain

new TerrainMaterial()
{
   diffuseMap = "art/terrains/rocky_seaweed/rocky_seaweed_base";
   normalMap = "art/terrains/rocky_seaweed/rocky_seaweed_nrm";
   detailMap = "art/terrains/rocky_seaweed/rocky_seaweed_dif";
   internalName = "RockySeaweed";
   detailSize = "9";
   detailStrength = "0.2";
   detailDistance = "1000";
   parallaxScale = "0.03";
};

// RockyGroundSmall

new TerrainMaterial()
{
   diffuseMap = "art/terrains/rocky ground with grass/rockygroundwithgrass_base";
   normalMap = "art/terrains/rocky ground with grass/rockygroundwithgrass_normal_displacement";
   detailMap = "art/terrains/rocky ground with grass/rockygroundwithgrass_detail";
   detailSize = "2.8";
   detailStrength = "1";
   parallaxScale = "0";
   internalName = "RockGroundSmall";
   detailScale = "256";
   diffuseSize = "50";
};

/*

new TerrainMaterial()
{
   internalName = "ForestMix";
   diffuseMap = "art/terrains/forest mix/forestmix_base";
   normalMap = "art/terrains/forest mix/forestmix_normal_displacement";
   detailMap = "art/terrains/forest mix/forestmix_detail";
   detailScale = "512";
   detailSize = "3";
   parallaxScale = "0.02";
   detailDistance = "80";
};

singleton Material( Terrain_SFX_ForestMix_Mat )
{
   mapTo = "forestmix_base";
   customFootstepSound = Dirt_Step_Sound;
};

*/


// NO TERRAINS SHOULD APPEAR UNDER HERE


new TerrainMaterial()
{
   diffuseMap = "art/terrains/White/white";
   detailMap = "art/terrains/White/white";
   detailSize = "2";
   detailStrength = "0.8";
   detailDistance = "100";
   parallaxScale = "0.02";
   internalName = "DirtySand3";
   detailScale = "512";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/White/white";
   detailMap = "art/terrains/White/white";
   internalName = "warning_material";
   detailScale = "128";
};

new TerrainMaterial()
{
   diffuseMap = "core/art/white";
   detailMap = "core/art/white";
   internalName = "warning_material";
   detailScale = "128";
};

new TerrainMaterial()
{
   diffuseMap = "core/art/white";
   detailMap = "core/art/white";
   internalName = "white";
   detailScale = "128";
};

new TerrainMaterial()
{
   diffuseMap = "art/terrains/forest mix/forestmix_base";
   normalMap = "art/terrains/forest mix/forestmix_normal_displacement";
   detailMap = "art/terrains/forest mix/forestmix_detail";
   internalName = "ForestFloor";
   detailScale = "128";
   parallaxScale = "0.05";
};
