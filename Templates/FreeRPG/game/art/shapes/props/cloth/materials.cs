singleton Material(clothframe_clothframe)
{
	mapTo = "clothframe";

	diffuseMap[0] = "art/shapes/props/cloth/tex_clothframe_dif";
	normalMap[0] = "art/shapes/props/cloth/tex_bridge_nrm";
	specularMap[0] = "";

	diffuseColor[0] = "1 1 1 1";
	specular[0] = "0.9 0.9 0.9 1";
	specularPower[0] = 29;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
   pixelSpecular[0] = "1";
   materialTag0 = "Prop";
};

//--- clothframe.DAE MATERIALS BEGIN ---
singleton Material(clothframe_ColorEffectR225G87B143_material)
{
	mapTo = "ColorEffectR225G87B143-material";

	diffuseMap[0] = "";
	normalMap[0] = "";
	specularMap[0] = "";

	diffuseColor[0] = "0.882353 0.341177 0.560784 1";
	specular[0] = "1 1 1 1";
	specularPower[0] = 10;

	doubleSided = false;
	translucent = false;
	translucentBlendOp = "None";
};

//--- clothframe.DAE MATERIALS END ---

