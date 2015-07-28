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

datablock ParticleEmitterNodeData(DefaultEmitterNodeData)
{
   timeMultiple = 1;
};

// Smoke

datablock ParticleData(Smoke)
{
   textureName          = "art/particles/smoke";
   dragCoefficient      = 0.3;
   gravityCoefficient   = -0.2;   // rises slowly
   inheritedVelFactor   = 0.00;
   lifetimeMS           = 3000;
   lifetimeVarianceMS   = 250;
   useInvAlpha          = true;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;

   sizes[0]      = 1.5;
   sizes[1]      = 2.75;
   sizes[2]      = 6.5;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(SmokeEmitter)
{
   ejectionPeriodMS = 400;
   periodVarianceMS = 5;

   ejectionVelocity = 0.0;
   velocityVariance = 0.0;

   thetaMin         = 0.0;
   thetaMax         = 90.0;

   particles        = Smoke;
};

datablock ParticleEmitterNodeData(SmokeEmitterNode)
{
   timeMultiple = 1;
};

// Ember

datablock ParticleData(EmberParticle)
{
   textureName          = "art/particles/ember";
   dragCoefficient      = 0.0;
   windCoefficient      = 0.0;
   gravityCoefficient   = -0.05;   // rises slowly
   inheritedVelFactor   = 0.00;
   lifetimeMS           = 5000;
   lifetimeVarianceMS   = 0;
   useInvAlpha          = false;
   spinRandomMin        = -90.0;
   spinRandomMax        = 90.0;
   spinSpeed            = 1;

   colors[0]     = "1.000000 0.800000 0.000000 0.800000";
   colors[1]     = "1.000000 0.700000 0.000000 0.800000";
   colors[2]     = "1.000000 0.000000 0.000000 0.200000";

   sizes[0]      = 0.05;
   sizes[1]      = 0.1;
   sizes[2]      = 0.05;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(EmberEmitter)
{
   ejectionPeriodMS = 100;
   periodVarianceMS = 0;

   ejectionVelocity = 0.75;
   velocityVariance = 0.00;
   ejectionOffset   = 2.0;

   thetaMin         = 1.0;
   thetaMax         = 100.0;

   particles        = "EmberParticle";
};

datablock ParticleEmitterNodeData(EmberNode)
{
   timeMultiple = 1;
};

// Fire

datablock ParticleData(FireParticle)
{
   textureName          = "art/particles/smoke";
   dragCoefficient      = 0.0;
   windCoefficient      = 0.0;
   gravityCoefficient   = -0.05;   // rises slowly
   inheritedVelFactor   = 0.00;
   lifetimeMS           = 5000;
   lifetimeVarianceMS   = 1000;
   useInvAlpha          = false;
   spinRandomMin        = -90.0;
   spinRandomMax        = 90.0;
   spinSpeed            = 1.0;

   colors[0]     = "0.2 0.2 0.0 0.2";
   colors[1]     = "0.6 0.2 0.0 0.2";
   colors[2]     = "0.4 0.0 0.0 0.1";
   colors[3]     = "0.1 0.04 0.0 0.3";

   sizes[0]      = 0.5;
   sizes[1]      = 4.0;
   sizes[2]      = 5.0;
   sizes[3]      = 6.0;

   times[0]      = 0.0;
   times[1]      = 0.1;
   times[2]      = 0.2;
   times[3]      = 0.3;
};

datablock ParticleEmitterData(FireEmitter)
{
   ejectionPeriodMS = 50;
   periodVarianceMS = 0;

   ejectionVelocity = 0.55;
   velocityVariance = 0.00;
   ejectionOffset   = 1.0;


   thetaMin         = 1.0;
   thetaMax         = 100.0;

   particles        = "FireParticle";
};

datablock ParticleEmitterNodeData(FireNode)
{
   timeMultiple = 1;
};

// Torch Fire

datablock ParticleData(TorchFire1)
{
   textureName          = "art/particles/smoke";
   dragCoefficient      = 0.0;
   gravityCoefficient   = -0.3;   // rises slowly
   inheritedVelFactor   = 0.00;
   lifetimeMS           = 500;
   lifetimeVarianceMS   = 250;
   useInvAlpha          = false;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;
   spinSpeed            = 1;

   colors[0]     = "0.6 0.6 0.0 0.1";
   colors[1]     = "0.8 0.6 0.0 0.1";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = 0.5;
   sizes[1]      = 0.5;
   sizes[2]      = 2.4;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleData(TorchFire2)
{
   textureName          = "art/particles/smoke";
   dragCoefficient      = 0.0;
   gravityCoefficient   = -0.5;   // rises slowly
   inheritedVelFactor   = 0.00;
   lifetimeMS           = 800;
   lifetimeVarianceMS   = 150;
   useInvAlpha          = false;
   spinRandomMin        = -30.0;
   spinRandomMax        = 30.0;
   spinSpeed            = 1;

   colors[0]     = "0.8 0.6 0.0 0.1";
   colors[1]     = "0.6 0.6 0.0 0.1";
   colors[2]     = "0.0 0.0 0.0 0.1";

   sizes[0]      = 0.3;
   sizes[1]      = 0.3;
   sizes[2]      = 0.3;

   times[0]      = 0.0;
   times[1]      = 0.5;
   times[2]      = 1.0;
};

datablock ParticleEmitterData(TorchFireEmitter)
{
   ejectionPeriodMS = 15;
   periodVarianceMS = 5;

   ejectionVelocity = 0.25;
   velocityVariance = 0.10;

   thetaMin         = 0.0;
   thetaMax         = 45.0;

   particles        = "TorchFire1" TAB "TorchFire2";
};

datablock ParticleEmitterNodeData(TorchFireEmitterNode)
{
   timeMultiple = 1;
};


datablock ParticleEmitterNodeData(DefaultParticleEmitterNodeData)
{
   timeMultiple = 1;
};

datablock ParticleData(ParticleMist)
{
   textureName = "art/shapes/particles/sickieparticles/mist.png";
   dragCoeffiecient = 0;
   gravityCoefficient = "-0.0854701";
   inheritedVelFactor = 0;
   constantAcceleration = -1;
   lifetimeMS = 2500;
   lifetimeVarianceMS = 0;
   useInvAlpha = 0;
   spinRandomMin = -125;
   spinRandomMax = 125;
   spinSpeed = 0.520833;

   colors[0] = "0.992126 0.992126 0.992126 0.436";
   colors[1] = "0.992126 0.992126 0.992126 0.465";
   colors[2] = "0.992126 0.992126 0.992126 0.668";
   colors[3] = "0.992126 0.992126 0.992126 0.23622";
   
   sizes[0] = 2;
   sizes[1] = 8;
   sizes[2] = 9;
   sizes[3] = "10.5";
   
   times[0] = 0.0;
   times[1] = "0.4";
   times[2] = "0.5";
   times[3] = "0.6";
   
   animTexName = "art/shapes/particles/sickieparticles/mist.png";
   
   dragCoefficient = "0.889541";
};

datablock ParticleData(ParticleMainFalls01)
{
   textureName = "art/shapes/particles/sickieparticles/main falls 01.png";
   animTexName = "art/shapes/particles/sickieparticles/main falls 01.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleMainFalls02)
{
   textureName = "art/shapes/particles/sickieparticles/main falls 02.png";
   animTexName = "art/shapes/particles/sickieparticles/main falls 02.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleMainFalls03)
{
   textureName = "art/shapes/particles/sickieparticles/main falls 03.png";
   animTexName = "art/shapes/particles/sickieparticles/main falls 03.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleRockImpactInner01)
{
   textureName = "art/shapes/particles/sickieparticles/rock_impact_1_inner.png";
   animTexName = "art/shapes/particles/sickieparticles/rock_impact_1_inner.png";
   gravityCoefficient = "0.541667";
   inheritedVelFactor = "1.875";
   spinSpeed = "0.229167";
   spinRandomMin = "-416";
   spinRandomMax = "541.9";
   colors[2] = "1 1 1 0.124481";
   colors[3] = "1 1 1 0.136929";
   sizes[1] = "3";
   sizes[2] = "3";
   sizes[3] = "3";
   times[1] = "0.25";
   times[2] = "0.6875";
};

datablock ParticleData(ParticleRockImpactTop)
{
   textureName = "art/shapes/particles/sickieparticles/top and top spray.png";
   animTexName = "art/shapes/particles/sickieparticles/top and top spray.png";
   gravityCoefficient = "0.124542";
   colors[1] = "0.996078 0.996078 0.996078 0.813";
   colors[2] = "1 1 1 0.581";
   colors[3] = "1 1 1 0.015748";
   sizes[1] = "1.99597";
   sizes[2] = "1.99597";
   sizes[3] = "1.99597";
   times[1] = "0.329412";
   times[2] = "0.658824";
   spinRandomMin = "-43";
   spinRandomMax = "42";
   colors[0] = "1 1 1 0";
   sizes[0] = "1.99597";
   times[3] = "0.992157";
};

datablock ParticleData(ParticleWaterDisturbance)
{
   textureName = "art/shapes/particles/sickieparticles/ripple.png";
   animTexName = "art/shapes/particles/sickieparticles/ripple.png";
   lifetimeMS = "2626";
   lifetimeVarianceMS = "49";
   spinRandomMin = "0";
   spinRandomMax = "5";
   colors[0] = "1 1 1 0.173228";
   colors[1] = "1 1 1 1";
   colors[2] = "1 1 1 0.409449";
   colors[3] = "1 1 1 0.0393701";
   sizes[1] = "10.6543";
   sizes[2] = "15.9952";
   sizes[3] = "18.6565";
   times[1] = "0.247059";
   times[2] = "0.513726";
   times[3] = "1";
   spinSpeed = "0";
   sizes[0] = "5.32564";
};

datablock ParticleEmitterData(EmitterMist)
{
   particles = "ParticleMist";
   blendStyle = "NORMAL";
   ejectionVelocity = "5.11";
   velocityVariance = "0";
   thetaMax = "165";
   softParticles = "1";
   ambientFactor = "0.416667";
   ejectionPeriodMS = "167";
};

datablock ParticleEmitterData(EmitterMainFalls)
{
   particles = "ParticleMainFalls01";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "10";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0";
};

datablock ParticleEmitterData(EmitterMainFalls02)
{
   particles = "ParticleMainFalls02";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "10";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0";
};

datablock ParticleEmitterData(EmitterMainFalls03)
{
   particles = "ParticleMainFalls03";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "25";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0";
};

datablock ParticleEmitterData(EmitterTopSpray)
{
   particles = "ParticleRockImpactTop";
   blendStyle = "NORMAL";
   ejectionVelocity = "1";
   velocityVariance = "0";
   ejectionPeriodMS = "272";
   ambientFactor = "0";
   periodVarianceMS = "0";
   thetaMin = "0";
   thetaMax = "90";
   phiVariance = "360";
   alignParticles = "0";
   softParticles = "0";
};

datablock ParticleEmitterData(EmitterWaterDisturbance)
{
   particles = "ParticleWaterDisturbance";
   blendStyle = "NORMAL";
   thetaMin = "7";
   thetaMax = "180";
   orientParticles = "0";
   ejectionPeriodMS = "646";
   periodVarianceMS = "24";
   ejectionVelocity = "0";
   velocityVariance = "0";
   phiVariance = "1";
   alignParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0";
   softParticles = "0";
   alignDirection = "0 0 1";
};

datablock ParticleEmitterData(EmitterRockImpact)
{
   particles = "ParticleRockImpactInner01";
   blendStyle = "NORMAL";
   ejectionPeriodMS = "167";
   velocityVariance = "0";
   softParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0";
};

datablock ParticleEmitterData(EmitterTop)
{
   particles = "DefaultParticle";
   blendStyle = "NORMAL";
   ejectionPeriodMS = "417";
   ejectionVelocity = "69.05";
   velocityVariance = "59.81";
   ambientFactor = "0";
};


datablock ParticleData(ParticleSplinter)
{
   textureName = "art/shapes/particles/splinters.png";
   animTexName = "art/shapes/particles/splinters.png";
   lifetimeMS = "1501";
   lifetimeVarianceMS = "0";
   spinRandomMin = "-750";
   spinRandomMax = "666";
   colors[0] = "0.992126 0.992126 0.992126 1";
   colors[1] = "0.992126 0.992126 0.992126 1";
   colors[2] = "0.992126 0.992126 0.992126 1";
   colors[3] = "0.992126 0.992126 0.992126 1";
   sizes[1] = "0.25";
   sizes[2] = "0.25";
   sizes[3] = "0";
   times[1] = "0.247059";
   times[2] = "0.513726";
   times[3] = "0.686275";
   spinSpeed = "1";
   sizes[0] = "0.5";
   gravityCoefficient = "0.542";
   inheritedVelFactor = "0.833";
   constantAcceleration = "0.417";
};



datablock ParticleEmitterData(EmitterSplinter)
{
   ejectionPeriodMS = 1;
   periodVarianceMS = 0;
   ejectionVelocity = 3.0;
   velocityVariance = 1.0;
   thetaMin         = 0.0;
   thetaMax         = 180.0;
   lifetimeMS       = 166;
   particles = "ParticleSplinter ParticleSplinter2 ParticleSplinter3";
   blendStyle = "NORMAL";
   ejectionOffset = "2.5";
   softnessDistance = "0";
   softParticles = "0";
   lifetimeVarianceMS = "20";
   ambientFactor = "0.416667";
};


datablock ParticleData(shrinefireparticle)
{
   textureName          = "art/shapes/particles/FXpack1/explosion";
   dragCoeffiecient     = 0;
   gravityCoefficient   = -0.5;
   inheritedVelFactor   = "0.8";
   constantAcceleration = "-3";
   lifetimeMS           = "950";
   lifetimeVarianceMS   = 400;
   useInvAlpha =  false;
   spinRandomMin = -280.0;
   spinRandomMax =  280.0;

   colors[0]     = "0.992126 0.937008 0.566929 0.0944882";
   colors[1]     = "1 0.496063 0 0.299213";
   colors[2]     = "0.0944882 0.0944882 0.0944882 0";
   colors[3]     = "0.992157 0.992157 0.992157 0";

   sizes[0]      = "0.6";
   sizes[1]      = "1.3";
   sizes[2]      = 0.4;

   times[0]      = 0.0;
   times[1]      = "0.33";
   times[2]      = "1";
   dragCoefficient = 0.25;
   spinSpeed = "0.5";
   animTexName = "art/shapes/particles/FXpack1/explosion";
   sizes[3] = "0";
   times[3] = "1";
};

datablock ParticleEmitterData(shrine_fire_emitter)
{
   ejectionPeriodMS = 25;
   ejectionVelocity = 0.5;
   velocityVariance = "0";
   ejectionOffset = 0;
   thetaMax = "100";
   particles = "shrinefireparticle";
   blendStyle = "ADDITIVE";
   softParticles = "1";
   softnessDistance = 1;
   periodVarianceMS = "23";
   thetaMin = "0";
};

datablock ParticleData(ParticleSplinter2)
{
   gravityCoefficient = "0.5";
   inheritedVelFactor = "0.6";
   constantAcceleration = "0.4";
   lifetimeMS = "1400";
   spinRandomMin = "-800";
   spinRandomMax = "700";
   textureName = "art/shapes/particles/splinters_02.png";
   animTexName = "art/shapes/particles/splinters_02.png";
   sizes[0] = "0.4";
   sizes[1] = "0.2";
   sizes[2] = "0.2";
   sizes[3] = "0";
   times[3] = "0.6";
};

datablock ParticleData(ParticleSplinter3)
{
   gravityCoefficient = "0.7";
   inheritedVelFactor = "0.7";
   constantAcceleration = "0.5";
   lifetimeMS = "1800";
   lifetimeVarianceMS = "100";
   spinRandomMin = "-800";
   spinRandomMax = "900";
   textureName = "art/shapes/particles/splinters_03.png";
   animTexName = "art/shapes/particles/splinters_03.png";
   sizes[0] = "0.3";
   sizes[1] = "0.2";
   sizes[2] = "0.2";
   sizes[3] = "0";
   times[1] = "0.2";
   times[2] = "0.4";
   times[3] = "0.5";
};


datablock ParticleData(ParticleSteamData)
{
   textureName = "art/shapes/particles/smoke2.png";
   animTexName = "art/shapes/particles/smoke2.png";
   lifetimeMS = "5000";
   lifetimeVarianceMS = "250";
   spinRandomMin = "-25";
   spinRandomMax = "25";
   colors[0] = "0.992126 0.992126 0.992126 0";
   colors[1] = "0.992126 0.992126 0.992126 0.207";
   colors[2] = "0.992126 0.992126 0.992126 0";
   colors[3] = "0.992126 0.992126 0.992126 1";
   sizes[1] = "33.3303";
   sizes[2] = "31.2489";
   sizes[3] = "0";
   times[1] = "0.498039";
   times[2] = "1";
   times[3] = "1";
   spinSpeed = "0.05";
   sizes[0] = "27.083";
   gravityCoefficient = "0";
   inheritedVelFactor = "0";
   constantAcceleration = "0";
};



datablock ParticleEmitterData(ParticleSteamEmitter)
{
   ejectionPeriodMS = 625;
   periodVarianceMS = 10;
   ejectionVelocity = 0;
   velocityVariance = 0;
   thetaMin         = 0.0;
   thetaMax         = 39;
   lifetimeMS       = 0;
   particles = "ParticleSteamData";
   blendStyle = "NORMAL";
   ejectionOffset = "40";
   softnessDistance = "1";
   softParticles = "1";
   lifetimeVarianceMS = "0";
};

datablock ParticleData(lavaParticle)
{
   textureName = "art/shapes/particles/fxpack1/waterspray.png";
   animTexName = "art/shapes/particles/fxpack1/waterspray.png";
   dragCoefficient = "0.591398";
   gravityCoefficient = "0.290598";
   lifetimeMS = "3750";
   lifetimeVarianceMS = "3000";
   colors[0] = "1 0.519685 0 1";
   colors[1] = "1 0.0472441 0 1";
   colors[2] = "1 0.0705882 0 0.797";
   sizes[0] = "1.04071";
   sizes[1] = "3.99805";
   sizes[3] = "0";
   colors[3] = "1 0.207843 0 0.299";
   spinRandomMin = "0";
   spinRandomMax = "2";
   times[3] = "2";
   inheritedVelFactor = "1";
   constantAcceleration = "0.1";
   times[0] = "0";
   times[2] = "1";
};

datablock ParticleEmitterData(LavaSprayEmitter)
{
   ejectionPeriodMS = "85";
   periodVarianceMS = "40";
   ejectionVelocity = "2";
   velocityVariance = "2";
   thetaMax = "45";
   particles = "lavaParticle";
   blendStyle = "NORMAL";
   ejectionOffset = "0";
   phiVariance = "10";
   softnessDistance = "10";
   softParticles = "1";
   alignDirection = "1 0 0";
   thetaMin = "5";
};

datablock ParticleData(lavaParticleTop)
{
   textureName = "art/shapes/particles/fxpack1/waterspray.png";
   animTexName = "art/shapes/particles/fxpack1/waterspray.png";
   dragCoefficient = "0.591398";
   gravityCoefficient = "0.290598";
   lifetimeMS = "1126";
   lifetimeVarianceMS = "1125";
   colors[0] = "1 0.580392 0 1";
   colors[1] = "1 0.603922 0 1";
   colors[2] = "1 0.509804 0 1";
   sizes[0] = "0";
   sizes[1] = "1.5";
   sizes[3] = "6";
   colors[3] = "1 0.207843 0 1";
   spinRandomMin = "0";
   spinRandomMax = "2";
   times[3] = "1";
   inheritedVelFactor = "1";
   constantAcceleration = "0.1";
   times[0] = "0";
   times[2] = "1";
   sizes[2] = "4";
   times[1] = "0.291667";
};

datablock ParticleEmitterData(LavaSprayTop)
{
   ejectionPeriodMS = "85";
   periodVarianceMS = "40";
   ejectionVelocity = "2";
   velocityVariance = "2";
   thetaMax = "45";
   particles = "lavaParticleTop";
   blendStyle = "NORMAL";
   ejectionOffset = "0.208";
   phiVariance = "10";
   softnessDistance = "10";
   softParticles = "1";
   alignDirection = "1 0 0";
   thetaMin = "5";
};


datablock ParticleData(LavaSteamData)
{
   textureName = "art/shapes/particles/smoke2.png";
   animTexName = "art/shapes/particles/smoke2.png";
   lifetimeMS = "5500";
   lifetimeVarianceMS = "350";
   spinRandomMin = "-28";
   spinRandomMax = "24";
   colors[0] = "0.996078 0.780392 0.458824 0.023622";
   colors[1] = "0.996078 0.698039 0.439216 0.11811";
   colors[2] = "0.996078 0.698039 0.439216 0.0472441";
   colors[3] = "0.988235 0.788235 0.0117647 1";
   sizes[1] = "29.9976";
   sizes[2] = "15.9983";
   sizes[3] = "0";
   times[1] = "0.6";
   times[2] = "1";
   times[3] = "1";
   spinSpeed = "0.1";
   sizes[0] = "19.9994";
   gravityCoefficient = "-0.0708181";
   inheritedVelFactor = "0";
   constantAcceleration = "0";
   dragCoefficient = "0";
};



datablock ParticleEmitterData(LavaSteamEmitter)
{
   ejectionPeriodMS = 625;
   periodVarianceMS = 10;
   ejectionVelocity = 0;
   velocityVariance = 0;
   thetaMin         = 0.0;
   thetaMax         = 39;
   lifetimeMS       = 0;
   particles = "LavaSteamData";
   blendStyle = "NORMAL";
   ejectionOffset = "8";
   softnessDistance = "1";
   softParticles = "1";
   lifetimeVarianceMS = "0";
};

datablock ParticleData(LavaMagmaParticle)
{
   textureName = "art/shapes/particles/fxpack1/spark.png";
   animTexName = "art/shapes/particles/fxpack1/spark.png";
   dragCoefficient = "0.997067";
   gravityCoefficient = "2";
   lifetimeMS = "3500";
   lifetimeVarianceMS = "1000";
   colors[0] = "1 0.88189 0 1";
   colors[1] = "1 0.834646 0 1";
   colors[2] = "1 0.0551181 0 0.866142";
   sizes[0] = "0.497467";
   sizes[1] = "1.99902";
   sizes[3] = "5.99707";
   colors[3] = "1 0.0551181 0 0.700787";
   spinRandomMin = "0";
   spinRandomMax = "4";
   times[3] = "0.898039";
   inheritedVelFactor = "0.996086";
   constantAcceleration = "0";
   times[0] = "0";
   sizes[2] = "2.99701";
   times[1] = "0.4";
   times[2] = "0.898039";
};

datablock ParticleEmitterData(LavaMagmaEmitter)
{
   ejectionPeriodMS = "60";
   periodVarianceMS = "0";
   ejectionVelocity = "7.5";
   velocityVariance = "0.2";
   thetaMax = "20";
   particles = "lavamagmaParticle";
   blendStyle = "NORMAL";
   ejectionOffset = "0";
   phiVariance = "360";
   softnessDistance = "1";
   softParticles = "1";
   alignDirection = "1 0 0";
   thetaMin = "12";
   orientParticles = "1";
   alignParticles = "0";
};

datablock ParticleData(LavaDisturbanceParticle)
{
   textureName = "art/shapes/particles/sickieparticles/ripple.png";
   animTexName = "art/shapes/particles/sickieparticles/ripple.png";
   lifetimeMS = "8000";
   lifetimeVarianceMS = "0";
   spinRandomMin = "0";
   spinRandomMax = "0";
   colors[0] = "1 0.614173 0 1";
   colors[1] = "1 0.322835 0 1";
   colors[2] = "0.992126 0.0551181 0 1";
   colors[3] = "1 0.0472441 0 1";
   sizes[1] = "3.99805";
   sizes[2] = "5.99402";
   sizes[3] = "5.99402";
   times[1] = "0.141176";
   times[2] = "0.286275";
   times[3] = "0.329412";
   spinSpeed = "0";
   sizes[0] = "3.99805";
   constantAcceleration = "0";
};

datablock ParticleEmitterData(LavaDisturbanceEmitter)
{
   particles = "LavaDisturbanceParticle";
   blendStyle = "NORMAL";
   thetaMin = "7";
   thetaMax = "180";
   orientParticles = "0";
   ejectionPeriodMS = "646";
   periodVarianceMS = "24";
   ejectionVelocity = "0";
   velocityVariance = "0";
   phiVariance = "1";
   alignParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0";
   softParticles = "0";
   alignDirection = "0 0 1";
};

datablock ParticleData(WaterVortexParticle)
{
   textureName = "art/shapes/particles/sickieparticles/rock impact top and side spray.png";
   animTexName = "art/shapes/particles/sickieparticles/rock impact top and side spray.png";
   lifetimeMS = "8000";
   lifetimeVarianceMS = "4800";
   spinRandomMin = "-100";
   spinRandomMax = "120";
   colors[0] = "0.643137 0.643137 0.643137 0.141";
   colors[1] = "0.913726 0.909804 0.909804 0.763";
   colors[2] = "0.917647 0.913726 0.913726 0.726";
   colors[3] = "0.933333 0.929412 0.929412 0.11811";
   sizes[1] = "8";
   sizes[2] = "4";
   sizes[3] = "2";
   times[1] = "0.25";
   times[2] = "0.5";
   times[3] = "0.8";
   spinSpeed = "0.4";
   sizes[0] = "11";
   constantAcceleration = "-2.5";
   inheritedVelFactor = "1";
};

datablock ParticleEmitterData(WaterVortexEmitter)
{
   particles = "WaterVortexParticle";
   blendStyle = "NORMAL";
   thetaMin = "7";
   thetaMax = "180";
   orientParticles = "0";
   ejectionPeriodMS = "646";
   periodVarianceMS = "24";
   ejectionVelocity = "0";
   velocityVariance = "0";
   phiVariance = "360";
   alignParticles = "0";
   softnessDistance = "1";
   ambientFactor = "0";
   softParticles = "1";
   ejectionOffset = "0";
};




// Duplicated Particles for Cave ---------------------------------------------------------------------

datablock ParticleData(ParticleMist_Cave)
{
   textureName = "art/shapes/particles/sickieparticles/mist.png";
   dragCoeffiecient = 0;
   gravityCoefficient = "-0.0854701";
   inheritedVelFactor = 0;
   constantAcceleration = -1;
   lifetimeMS = 2500;
   lifetimeVarianceMS = 0;
   useInvAlpha = 0;
   spinRandomMin = -125;
   spinRandomMax = 125;
   spinSpeed = 0.520833;

   colors[0] = "0.992126 0.992126 0.992126 0.436";
   colors[1] = "0.992126 0.992126 0.992126 0.465";
   colors[2] = "0.992126 0.992126 0.992126 0.668";
   colors[3] = "0.992126 0.992126 0.992126 0.23622";
   
   sizes[0] = 2;
   sizes[1] = 8;
   sizes[2] = 9;
   sizes[3] = "10.5";
   
   times[0] = 0.0;
   times[1] = "0.4";
   times[2] = "0.5";
   times[3] = "0.6";
   
   animTexName = "art/shapes/particles/sickieparticles/mist.png";
   
   dragCoefficient = "0.889541";
};

datablock ParticleData(ParticleMainFalls01_Cave)
{
   textureName = "art/shapes/particles/sickieparticles/main falls 01.png";
   animTexName = "art/shapes/particles/sickieparticles/main falls 01.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleMainFalls02_Cave)
{
   textureName = "art/shapes/particles/sickieparticles/main falls 02.png";
   animTexName = "art/shapes/particles/sickieparticles/main falls 02.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleMainFalls03_Cave)
{
   textureName = "art/shapes/particles/sickieparticles/main falls 03.png";
   animTexName = "art/shapes/particles/sickieparticles/main falls 03.png";
   gravityCoefficient = "0.788767";
   sizes[0] = "1.99902";
   sizes[1] = "7.99915";
   constantAcceleration = "0.416666";
   sizes[2] = "0";
   sizes[3] = "0";
   lifetimeMS = "2064";
};

datablock ParticleData(ParticleRockImpactInner01_Cave)
{
   textureName = "art/shapes/particles/sickieparticles/rock_impact_1_inner.png";
   animTexName = "art/shapes/particles/sickieparticles/rock_impact_1_inner.png";
   gravityCoefficient = "0.541667";
   inheritedVelFactor = "1.875";
   spinSpeed = "0.229167";
   spinRandomMin = "-416";
   spinRandomMax = "541.9";
   colors[2] = "1 1 1 0.124481";
   colors[3] = "1 1 1 0.136929";
   sizes[1] = "3";
   sizes[2] = "3";
   sizes[3] = "3";
   times[1] = "0.25";
   times[2] = "0.6875";
};

datablock ParticleData(ParticleRockImpactTop_Cave)
{
   textureName = "art/shapes/particles/sickieparticles/top and top spray.png";
   animTexName = "art/shapes/particles/sickieparticles/top and top spray.png";
   gravityCoefficient = "0.124542";
   colors[1] = "0.996078 0.996078 0.996078 0.813";
   colors[2] = "1 1 1 0.581";
   colors[3] = "1 1 1 0.015748";
   sizes[1] = "1.99597";
   sizes[2] = "1.99597";
   sizes[3] = "1.99597";
   times[1] = "0.329412";
   times[2] = "0.658824";
   spinRandomMin = "-43";
   spinRandomMax = "42";
   colors[0] = "1 1 1 0";
   sizes[0] = "1.99597";
   times[3] = "0.992157";
};

datablock ParticleData(ParticleWaterDisturbance_Cave)
{
   textureName = "art/shapes/particles/sickieparticles/ripple.png";
   animTexName = "art/shapes/particles/sickieparticles/ripple.png";
   lifetimeMS = "2626";
   lifetimeVarianceMS = "49";
   spinRandomMin = "0";
   spinRandomMax = "5";
   colors[0] = "1 1 1 0.173228";
   colors[1] = "1 1 1 1";
   colors[2] = "1 1 1 0.409449";
   colors[3] = "1 1 1 0.0393701";
   sizes[1] = "10.6543";
   sizes[2] = "15.9952";
   sizes[3] = "18.6565";
   times[1] = "0.247059";
   times[2] = "0.513726";
   times[3] = "1";
   spinSpeed = "0";
   sizes[0] = "5.32564";
};

datablock ParticleEmitterData(EmitterMist_Cave)
{
   particles = "ParticleMist_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "5.11";
   velocityVariance = "0";
   thetaMax = "165";
   softParticles = "1";
   ambientFactor = "0.416667";
   ejectionPeriodMS = "167";
};

datablock ParticleEmitterData(EmitterMainFalls_Cave)
{
   particles = "ParticleMainFalls01_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "10";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0.416667";
};

datablock ParticleEmitterData(EmitterMainFalls02_Cave)
{
   particles = "ParticleMainFalls02_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "10";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0.416667";
};

datablock ParticleEmitterData(EmitterMainFalls03_Cave)
{
   particles = "ParticleMainFalls03_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "3.5";
   velocityVariance = "0";
   thetaMax = "25";
   ejectionPeriodMS = "146";
   softnessDistance = "1";
   orientParticles = "1";
   softParticles = "1";
   lifetimeMS = "0";
   ambientFactor = "0.416667";
};

datablock ParticleEmitterData(EmitterWaterDisturbance_Cave)
{
   particles = "ParticleWaterDisturbance_Cave";
   blendStyle = "NORMAL";
   ejectionVelocity = "0";
   velocityVariance = "0";
   ejectionPeriodMS = "646";
   ambientFactor = "0.416667";
   periodVarianceMS = "24";
   thetaMin = "7";
   thetaMax = "180";
   phiVariance = "1";
   alignParticles = "1";
   softParticles = "0";
   alignDirection = "0 0 1";
};

datablock ParticleEmitterData(EmitterWaterDisturbance_Cave)
{
   particles = "ParticleWaterDisturbance_Cave";
   blendStyle = "NORMAL";
   thetaMin = "7";
   thetaMax = "180";
   orientParticles = "0";
   ejectionPeriodMS = "646";
   periodVarianceMS = "24";
   ejectionVelocity = "0";
   velocityVariance = "0";
   phiVariance = "1";
   alignParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0.416667";
   softParticles = "0";
};

datablock ParticleEmitterData(EmitterRockImpact_Cave)
{
   particles = "ParticleRockImpactInner01_Cave";
   blendStyle = "NORMAL";
   ejectionPeriodMS = "167";
   velocityVariance = "0";
   softParticles = "1";
   softnessDistance = "1";
   ambientFactor = "0.416667";
};