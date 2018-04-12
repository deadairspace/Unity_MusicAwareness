
public sealed partial class PoolMatcher {

    static Entitas.IMatcher<PoolEntity> _matcherAudioAttackSource;

    public static Entitas.IMatcher<PoolEntity> AudioAttackSource {
        get {
            if (_matcherAudioAttackSource == null) {
                var matcher = (Entitas.Matcher<PoolEntity>)Entitas.Matcher<PoolEntity>.AllOf(PoolComponentsLookup.AudioAttackSource);
                matcher.componentNames = PoolComponentsLookup.componentNames;
                _matcherAudioAttackSource = matcher;
            }

            return _matcherAudioAttackSource;
        }
    }
}
