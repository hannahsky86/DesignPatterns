namespace AdapterExample
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    class Adapter : ITarget
    {
        private readonly ThirdPartyTool _thirdPartyTool;

        public Adapter(ThirdPartyTool thirdPartyTool)
        {
            this._thirdPartyTool = thirdPartyTool;
        }

        public string DoSomeCoolThing()
        {
            return $"'{this._thirdPartyTool.DoSomeCoolThing()}' blindfolded.";
        }
    }

}
