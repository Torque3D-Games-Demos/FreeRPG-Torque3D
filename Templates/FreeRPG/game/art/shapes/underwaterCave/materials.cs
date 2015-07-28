//--- underwater_cave.DAE MATERIALS BEGIN ---
singleton Material(underwater_cave_tex_tunnel)
{
	mapTo = "tex_tunnel";

	diffuseMap[0] = "art/shapes/underwaterCave/underwater_cave_02_dif";
	normalMap[0] = "art/shapes/underwaterCave/underwater_cave_02_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   detailMap[0] = "art/shapes/volcano/volcano_cave_wall_tileable.dds";
   detailScale[0] = "6 6";
   detailNormalMap[0] = "art/shapes/physicsShapes/tex_tileable_noise_nrm.dds";
};

singleton Material(underwater_cave_tex_cave)
{
	mapTo = "tex_cave";

	diffuseMap[0] = "art/shapes/underwaterCave/underwater_cave_01_dif";
	normalMap[0] = "art/shapes/underwaterCave/underwater_cave_01_nrm.dds";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   detailMap[0] = "art/shapes/volcano/volcano_cave_wall_tileable.dds";
   detailScale[0] = "6 6";
   detailNormalMap[0] = "art/shapes/physicsShapes/tex_tileable_noise_nrm.dds";
};

//--- underwater_cave.DAE MATERIALS END ---

