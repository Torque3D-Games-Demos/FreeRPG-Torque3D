
singleton TSShapeConstructor(Bush01DAE)
{
   baseShape = "./Bush02.DAE";
   loadLights = "0";
};

function Bush01DAE::onLoad(%this)
{
   %this.addImposter("0", "6", "0", "0", "512", "1", "0");
}
