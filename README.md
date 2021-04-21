# Rhubarb Timeline
Unity Timeline tracks for Rhubarb Lip Sync

https://youtu.be/n_LAp6tTjv0

## Rhubarb
[Rhubarb Lip Sync](https://github.com/DanielSWolf/rhubarb-lip-sync) is a command-line tool that automatically creates 2D mouth animation from voice recordings. This Unity extension allows an animator to add a Rhubarb component to a Game Object with a properly configured Renderer, then animate the mouth shapes in a Timeline.

Using **Rhubarb Timeline**, a Timeline track can be automatically generated from an audio file.

## Rhubarb Sprite Based Generation
If the content being created is sprite based then the following components should be used:

### Rhubarb Sprite Set
To create a Rhubarb Sprite Set go to Assets > Create > Rhubarb > Sprite Set. A sprite should be referenced for each possible mouth shape. A premade Sprite Set "Lisa" has been included.

### Rhubarb Sprite Component
To add a Rhubarb Sprite Component to a Game Object click Add Component > Rhubarb Sprite. This will automatically add a Sprite Renderer to the Game Object if none is present. The desired Rhubarb Sprite Set can be set in the component.

## Rhubarb Material Based Generation
If the content being created is material based then the following components are available:

### Rhubarb Material Set
To create a Rhubarb Material Set go to Assets > Create > Rhubarb > Material Set. A material should be referenced for each possible mouth shape. A premade Material Set "Lisa" has been included.

### Rhubarb Material Component
To add a Rhubarb Material Component to a Game Object click Add Component > Rhubarb Material. This will automatically add a Mesh Renderer to the Game Object if none is present. The desired Rhubarb Material Set can be set in the component.

## Rhubarb Playable Track / Clip
To add a Rhubarb Playable Track to a Timeline click Add > Rhubarb Playable Track. To add clips (individual mouth shapes in the track) Right Click > Add Rhubarb Playable Clip. The Mouth Shape used can be set in the inspector.

## Rhubarb Timeline Window
To automatically create the Rhubarb Playable Track and Audio Track from an Audio Clip go to Window > Sequencing > Rhubarb Timeline.

You need to locate the Rhubarb application (downloaded from https://github.com/DanielSWolf/rhubarb-lip-sync/releases) on your hard drive. This does not have to be located in your Unity project folder.

Required settings that must be assigned before you can generate your tracks:

	- A Game Objects for the Timeline (Playable Director)
	- Audio Source
	- Rhubarb Binding Type Sprite or Material
	- Rhubarb Component Sprite or Material,
	- Audio Clip to be processed by the Rhubarb application

The AudioClip to be used for generation can be assigned, if you try and use a file without the extension ".wav" or ".ogg" you will get a warning and not be able to generate the tracks.

The other settings correspond to the command-line options for Rhubarb which can be found at https://github.com/DanielSWolf/rhubarb-lip-sync.

## Limitations
Rhubarb only supports WAVE (.wav) and Ogg Vorbis (.ogg) files.
This plugin has only been tested on Windows and OSX.
