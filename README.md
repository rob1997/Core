# Core
Core is a base Project containing basic and common implementation for other game projects
## Contents
### Damage System
The damage system is used to damage and take damage from character components, it contains 3 components
1. **Damage**
- This is the Data Component for any damage dealt or taken, it had a **DamageType**, **Amount**, **Damager** and **Damagable** components.
- A single blow/hit can have multiple damage types while damagables can have specific **Resistance** to specific **Damage Types**.
- Damage Dealt is calculated based on Resistance of Damagable in Damage
2. **Damager**
- This is the component that deals Damage to a Damagable
- It has events you can subscribe to like **OnDamageDealt** and **OnKillingBlow**
3. **Damagable**
- This is the a Monobhaviour component that should be attached/referenced together with a **Character** component.
- This is where **Resistance** for different **DamageType** is set and health points can be gained
- It has events you can subscribe to like **OnDamageTaken** **OnHealthGained** and **OnDeath**

### Utils
Utils, short for Utilities is where most commonly used components and fuctions can be found
- **GenericDictionary** : a dictionary that can be serialized using a custom editor
- **Singleton** : used on a Monobehaviour to make it a singleton/one instance during runtime that can be accessed statically
- **Utils** : a group of resuable static functions that are frequestly used

### Character and Game
This is where core components for the game and a character system is included, components such as
- **Character** attached to any game entity that can take actions
- **Controller** attached under a charater, a character can have multiple controllers
- **Action** is how a character performs actions. Attached under a controller, one controller can have many action
- **GameManager** holds multiple managers that manage specific aspects of the game.
