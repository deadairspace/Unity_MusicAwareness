
public sealed partial class PoolMatcher {

    static Entitas.IMatcher<PoolEntity> _matcherAudioWalkSource;

    public static Entitas.IMatcher<PoolEntity> AudioWalkSource {
        get {
            if (_matcherAudioWalkSource == null) {
                var matcher = (Entitas.Matcher<PoolEntity>)Entitas.Matcher<PoolEntity>.AllOf(PoolComponentsLookup.AudioWalkSource);
                matcher.componentNames = PoolComponentsLookup.componentNames;
                _matcherAudioWalkSource = matcher;
            }

            return _matcherAudioWalkSource;
        }
    }
}
