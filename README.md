# JARSUS
6.835 Spring 2022 Final Project Repo

# Setting Up
You will need:
* An Oculus Quest 2
* A USB-C cable
* Unity version 2020.3 or higher

To set up the project:
1. Clone the repo
2. In Unity Hub, click "Add" and select the "JARSUS" folder
3. You can now launch JARSUS
4. The default scene should be "FinalProject", but if it doesn't automatically open, it's under "Assets/Scenes/FinalProject". Open that.

# What all is in the Hierarchy
**Cylinder** is the basis for the file browser.
* The buttons for the files are under "Cylinder>Canvas (Alpha Blended)>Canvas>[Documents|Images|3d Files]>Viewport>Content"
* The spawner for the files is under the "On Click" component. You can change the file that should spawn with this.

**Poses** contains the poses that the system can recognize.
* The "Selector Unity Event Wrapper (Script)" component controls what happens when the pose is recognized
* The "Shape Recognizer Active State (Script)" component contains the hand features of the pose
  * There are more shapes under "Assets/Oculus/Interaction/Samples/Poses/Shapes", you can create your own and combine multiple features
* The "Transform Recognizer Active State (Script)" component contains information for the orientation of the hand during the pose.

**ObjectSpawner** is the container for the objects. You can use these as a basis by duplicating them.
* To avoid some strange behaviors, there need to be two copies of the object, a main and a base. On the main object, set the "Base Object Reference (Script)" component "Base Object" to the base object, and on the base object, set the "Base Object Reference (Script)" component "Base Object" to the main object.
* The necessary changes to get a working object are:
  * Change the object under "Visuals"
  * Give the object some sort of collision ("Box Collider", "Mesh Collider", etc)
  * Assign the mesh renderer of the object to the "Material Property Block Editor (Script)" component on "Visuals"
  * Assign the collider of the object to the "Collider Surface (Script)" component on "HandGrabInteractable"
  * Assign the object to the "On Add ()" function of the "Grabbable Unity Event Wrapper (Script)" on "Audio"
    * Yes I know I should've put it somewhere else but this was the easiest solution at the time

**GestureHints** contains the models on the table.
* Each hand model is manually posed by rotating the joints starting from "b_r_wrist"
* The placard text is editable at "Canvas>Panel>Text (TMP)"

**OculusInteractionSamplesButtonMenu** contains the buttons for hiding and showing "GestureHints"
