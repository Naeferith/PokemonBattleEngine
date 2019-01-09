using Kermalis.PokemonBattleEngine.Data;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Kermalis.PokemonBattleEngine.Localization
{
    public static class PBEAbilityLocalization
    {
        public static ReadOnlyDictionary<PBEAbility, PBELocalizedString> Names { get; } = new ReadOnlyDictionary<PBEAbility, PBELocalizedString>(new Dictionary<PBEAbility, PBELocalizedString>()
        {
            { PBEAbility.None, new PBELocalizedString("--", "--", "--", "--", "--", "--", "--") },
            { PBEAbility.Adaptability, new PBELocalizedString("てきおうりょく", "적응력", "Adaptabilité", "Anpassung", "Adaptable", "Adattabilità", "Adaptability") },
            { PBEAbility.Aftermath, new PBELocalizedString("ゆうばく", "유폭", "Boom Final", "Finalschlag", "Resquicio", "Scoppio", "Aftermath") },
            { PBEAbility.AirLock, new PBELocalizedString("エアロック", "에어록", "Air Lock", "Klimaschutz", "Bucle Aire", "Riparo", "Air Lock") },
            { PBEAbility.Analytic, new PBELocalizedString("アナライズ", "애널라이즈", "Analyste", "Analyse", "Cálc. Final", "Ponderazione", "Analytic") },
            { PBEAbility.AngerPoint, new PBELocalizedString("いかりのつぼ", "분노의경혈", "Colérique", "Kurzschluss", "Irascible", "Grancollera", "Anger Point") },
            { PBEAbility.Anticipation, new PBELocalizedString("きけんよち", "위험예지", "Anticipation", "Vorahnung", "Anticipación", "Presagio", "Anticipation") },
            { PBEAbility.ArenaTrap, new PBELocalizedString("ありじごく", "개미지옥", "Piège", "Ausweglos", "Trampa Arena", "Trappoarena", "Arena Trap") },
            { PBEAbility.BadDreams, new PBELocalizedString("ナイトメア", "나이트메어", "Mauvais Rêve", "Alptraum", "Mal Sueño", "Sogniamari", "Bad Dreams") },
            { PBEAbility.BattleArmor, new PBELocalizedString("カブトアーマー", "전투무장", "Armurbaston", "Kampfpanzer", "Armad. Bat.", "Lottascudo", "Battle Armor") },
            { PBEAbility.BigPecks, new PBELocalizedString("はとむね", "부풀린가슴", "Cœur de Coq", "Brustbieter", "Sacapecho", "Pettinfuori", "Big Pecks") },
            { PBEAbility.Blaze, new PBELocalizedString("もうか", "맹화", "Brasier", "Großbrand", "Mar Llamas", "Aiutofuoco", "Blaze") },
            { PBEAbility.Chlorophyll, new PBELocalizedString("ようりょくそ", "엽록소", "Chlorophyle", "Chlorophyll", "Clorofila", "Clorofilla", "Chlorophyll") },
            { PBEAbility.ClearBody, new PBELocalizedString("クリアボディ", "클리어바디", "Corps Sain", "Neutraltorso", "Cuerpo Puro", "Corpochiaro", "Clear Body") },
            { PBEAbility.CloudNine, new PBELocalizedString("ノーてんき", "날씨부정", "Ciel Gris", "Wolke Sieben", "Aclimatación", "Antimeteo", "Cloud Nine") },
            { PBEAbility.ColorChange, new PBELocalizedString("へんしょく", "변색", "Déguisement", "Farbwechsel", "Cambio Color", "Cambiacolore", "Color Change") },
            { PBEAbility.Compoundeyes, new PBELocalizedString("ふくがん", "복안", "Œil Composé", "Facettenauge", "Ojocompuesto", "Insettocchi", "Compoundeyes") },
            { PBEAbility.Contrary, new PBELocalizedString("あまのじゃく", "심술꾸러기", "Contestation", "Umkehrung", "Respondón", "Inversione", "Contrary") },
            { PBEAbility.CursedBody, new PBELocalizedString("のろわれボディ", "저주받은바디", "Corps Maudit", "Tastfluch", "Cue. Maldito", "Corpofunesto", "Cursed Body") },
            { PBEAbility.CuteCharm, new PBELocalizedString("メロメロボディ", "헤롱헤롱바디", "Joli Sourire", "Charmebolzen", "Gran Encanto", "Incantevole", "Cute Charm") },
            { PBEAbility.Damp, new PBELocalizedString("しめりけ", "습기", "Moiteur", "Feuchtigkeit", "Humedad", "Umidità", "Damp") },
            { PBEAbility.Defeatist, new PBELocalizedString("よわき", "무기력", "Défaitiste", "Schwächling", "Flaqueza", "Sconforto", "Defeatist") },
            { PBEAbility.Defiant, new PBELocalizedString("まけんき", "오기", "Acharné", "Siegeswille", "Competitivo", "Agonismo", "Defiant") },
            { PBEAbility.Download, new PBELocalizedString("ダウンロード", "다운로드", "Télécharge", "Download", "Descarga", "Download", "Download") },
            { PBEAbility.Drizzle, new PBELocalizedString("あめふらし", "잔비", "Crachin", "Niesel", "Llovizna", "Piovischio", "Drizzle") },
            { PBEAbility.Drought, new PBELocalizedString("ひでり", "가뭄", "Sécheresse", "Dürre", "Sequía", "Siccità", "Drought") },
            { PBEAbility.DrySkin, new PBELocalizedString("かんそうはだ", "건조피부", "Peau Sèche", "Trockenheit", "Piel Seca", "Pellearsa", "Dry Skin") },
            { PBEAbility.EarlyBird, new PBELocalizedString("はやおき", "일찍기상", "Matinal", "Frühwecker", "Madrugar", "Sveglialampo", "Early Bird") },
            { PBEAbility.EffectSpore, new PBELocalizedString("ほうし", "포자", "Pose Spore", "Sporenwirt", "Efec. Espora", "Spargispora", "Effect Spore") },
            { PBEAbility.Filter, new PBELocalizedString("フィルター", "필터", "Filtre", "Filter", "Filtro", "Filtro", "Filter") },
            { PBEAbility.FlameBody, new PBELocalizedString("ほのおのからだ", "불꽃몸", "Corps Ardent", "Flammkörper", "Cuerpo Llama", "Corpodifuoco", "Flame Body") },
            { PBEAbility.FlareBoost, new PBELocalizedString("ねつぼうそう", "열폭주", "Rage Brûlure", "Hitzewahn", "Ím. Ardiente", "Bruciaimpeto", "Flare Boost") },
            { PBEAbility.FlashFire, new PBELocalizedString("もらいび", "타오르는불꽃", "Torche", "Feuerfänger", "Absor. Fuego", "Fuocardore", "Flash Fire") },
            { PBEAbility.FlowerGift, new PBELocalizedString("フラワーギフト", "플라워기프트", "Don Floral", "Pflanzengabe", "Don Floral", "Regalfiore", "Flower Gift") },
            { PBEAbility.Forecast, new PBELocalizedString("てんきや", "기분파", "Météo", "Prognose", "Predicción", "Previsioni", "Forecast") },
            { PBEAbility.Forewarn, new PBELocalizedString("よちむ", "예지몽", "Prédiction", "Vorwarnung", "Alerta", "Premonizione", "Forewarn") },
            { PBEAbility.FriendGuard, new PBELocalizedString("フレンドガード", "프렌드가드", "Garde Amie", "Freundeshut", "Compiescolta", "Amicoscudo", "Friend Guard") },
            { PBEAbility.Frisk, new PBELocalizedString("おみとおし", "통찰", "Fouille", "Schnüffler", "Cacheo", "Indagine", "Frisk") },
            { PBEAbility.Gluttony, new PBELocalizedString("くいしんぼう", "먹보", "Gloutonnerie", "Völlerei", "Gula", "Voracità", "Gluttony") },
            { PBEAbility.Guts, new PBELocalizedString("こんじょう", "근성", "Cran", "Adrenalin", "Agallas", "Dentistretti", "Guts") },
            { PBEAbility.Harvest, new PBELocalizedString("しゅうかく", "수확", "Récolte", "Reiche Ernte", "Cosecha", "Coglibacche", "Harvest") },
            { PBEAbility.Healer, new PBELocalizedString("いやしのこころ", "치유의마음", "Cœur Soin", "Heilherz", "Alma Cura", "Curacuore", "Healer") },
            { PBEAbility.Heatproof, new PBELocalizedString("たいねつ", "내열", "Ignifugé", "Hitzeschutz", "Ignífugo", "Antifuoco", "Heatproof") },
            { PBEAbility.HeavyMetal, new PBELocalizedString("ヘヴィメタル", "헤비메탈", "Heavy Metal", "Schwermetall", "Met. Pesado", "Metalpesante", "Heavy Metal") },
            { PBEAbility.HoneyGather, new PBELocalizedString("みつあつめ", "꿀모으기", "Cherche Miel", "Honigmaul", "Recogemiel", "Mielincetta", "Honey Gather") },
            { PBEAbility.HugePower, new PBELocalizedString("ちからもち", "천하장사", "Coloforce", "Kraftkoloss", "Potencia", "Macroforza", "Huge Power") },
            { PBEAbility.Hustle, new PBELocalizedString("はりきり", "의욕", "Agitation", "Übereifer", "Entusiasmo", "Tuttafretta", "Hustle") },
            { PBEAbility.Hydration, new PBELocalizedString("うるおいボディ", "촉촉바디", "Hydratation", "Hydration", "Hidratación", "Idratazione", "Hydration") },
            { PBEAbility.HyperCutter, new PBELocalizedString("かいりきバサミ", "괴력집게", "Hyper Cutter", "Scherenmacht", "Corte Fuerte", "Ipertaglio", "Hyper Cutter") },
            { PBEAbility.IceBody, new PBELocalizedString("アイスボディ", "아이스바디", "Corps Gel", "Eishaut", "Gélido", "Corpogelo", "Ice Body") },
            { PBEAbility.Illuminate, new PBELocalizedString("はっこう", "발광", "Lumiattirance", "Erleuchtung", "Iluminación", "Risplendi", "Illuminate") },
            { PBEAbility.Illusion, new PBELocalizedString("イリュージョン", "일루전", "Illusion", "Trugbild", "Ilusión", "Illusione", "Illusion") },
            { PBEAbility.Immunity, new PBELocalizedString("めんえき", "면역", "Vaccin", "Immunität", "Inmunidad", "Immunità", "Immunity") },
            { PBEAbility.Imposter, new PBELocalizedString("かわりもの", "괴짜", "Imposteur", "Doppelgänger", "Impostor", "Sosia", "Imposter") },
            { PBEAbility.Infiltrator, new PBELocalizedString("すりぬけ", "틈새포착", "Infiltration", "Schwebedurch", "Allanamiento", "Intrapasso", "Infiltrator") },
            { PBEAbility.InnerFocus, new PBELocalizedString("せいしんりょく", "정신력", "Attention", "Konzentrator", "Foco Interno", "Fuocodentro", "Inner Focus") },
            { PBEAbility.Insomnia, new PBELocalizedString("ふみん", "불면", "Insomnia", "Insomnia", "Insomnio", "Insonnia", "Insomnia") },
            { PBEAbility.Intimidate, new PBELocalizedString("いかく", "위협", "Intimidation", "Bedroher", "Intimidación", "Prepotenza", "Intimidate") },
            { PBEAbility.IronBarbs, new PBELocalizedString("てつのトゲ", "철가시", "Épine de Fer", "Eisenstachel", "Punta Acero", "Spineferrate", "Iron Barbs") },
            { PBEAbility.IronFist, new PBELocalizedString("てつのこぶし", "철주먹", "Poing de Fer", "Eisenfaust", "Puño Férreo", "Ferropugno", "Iron Fist") },
            { PBEAbility.Justified, new PBELocalizedString("せいぎのこころ", "정의의마음", "Cœur Noble", "Redlichkeit", "Justiciero", "Giustizia", "Justified") },
            { PBEAbility.KeenEye, new PBELocalizedString("するどいめ", "날카로운눈", "Regard Vif", "Adlerauge", "Vista Lince", "Sguardofermo", "Keen Eye") },
            { PBEAbility.Klutz, new PBELocalizedString("ぶきよう", "서투름", "Maladresse", "Tollpatsch", "Zoquete", "Impaccio", "Klutz") },
            { PBEAbility.LeafGuard, new PBELocalizedString("リーフガード", "리프가드", "Feuil. Garde", "Floraschild", "Defensa Hoja", "Fogliamanto", "Leaf Guard") },
            { PBEAbility.Levitate, new PBELocalizedString("ふゆう", "부유", "Lévitation", "Schwebe", "Levitación", "Levitazione", "Levitate") },
            { PBEAbility.LightMetal, new PBELocalizedString("ライトメタル", "라이트메탈", "Light Metal", "Leichtmetall", "Met. Liviano", "Metalleggero", "Light Metal") },
            { PBEAbility.Lightningrod, new PBELocalizedString("ひらいしん", "피뢰침", "Paratonnerre", "Blitzfänger", "Pararrayos", "Parafulmine", "Lightningrod") },
            { PBEAbility.Limber, new PBELocalizedString("じゅうなん", "유연", "Échauffement", "Flexibilität", "Flexibilidad", "Scioltezza", "Limber") },
            { PBEAbility.LiquidOoze, new PBELocalizedString("ヘドロえき", "해감액", "Suintement", "Kloakensoße", "Lodo Líquido", "Melma", "Liquid Ooze") },
            { PBEAbility.MagicBounce, new PBELocalizedString("マジックミラー", "매직미러", "Miroir Magik", "Magiespiegel", "Espejomágico", "Magispecchio", "Magic Bounce") },
            { PBEAbility.MagicGuard, new PBELocalizedString("マジックガード", "매직가드", "Garde Magik", "Magieschild", "Muro Mágico", "Magicscudo", "Magic Guard") },
            { PBEAbility.MagmaArmor, new PBELocalizedString("マグマのよろい", "마그마의무장", "Armumagma", "Magmapanzer", "Escudo Magma", "Magmascudo", "Magma Armor") },
            { PBEAbility.MagnetPull, new PBELocalizedString("じりょく", "자력", "Magnépiège", "Magnetfalle", "Imán", "Magnetismo", "Magnet Pull") },
            { PBEAbility.MarvelScale, new PBELocalizedString("ふしぎなうろこ", "이상한비늘", "Écaille Spé.", "Notschutz", "Escama Esp.", "Pelledura", "Marvel Scale") },
            { PBEAbility.Minus, new PBELocalizedString("マイナス", "마이너스", "Minus", "Minus", "Menos", "Meno", "Minus") },
            { PBEAbility.MoldBreaker, new PBELocalizedString("かたやぶり", "틀깨기", "Brise Moule", "Überbrückung", "Rompemoldes", "Rompiforma", "Mold Breaker") },
            { PBEAbility.Moody, new PBELocalizedString("ムラっけ", "변덕쟁이", "Lunatique", "Gefühlswippe", "Veleta", "Altalena", "Moody") },
            { PBEAbility.MotorDrive, new PBELocalizedString("でんきエンジン", "전기엔진", "Motorisé", "Starthilfe", "Electromotor", "Elettrorapid", "Motor Drive") },
            { PBEAbility.Moxie, new PBELocalizedString("じしんかじょう", "자기과신", "Impudence", "Hochmut", "Autoestima", "Arroganza", "Moxie") },
            { PBEAbility.Multiscale, new PBELocalizedString("マルチスケイル", "멀티스케일", "Multiécaille", "Multischuppe", "Compensación", "Multisquame", "Multiscale") },
            { PBEAbility.Multitype, new PBELocalizedString("マルチタイプ", "멀티타입", "Multi-Type", "Variabilität", "Multitipo", "Multitipo", "Multitype") },
            { PBEAbility.Mummy, new PBELocalizedString("ミイラ", "미라", "Momie", "Mumie", "Momia", "Mummia", "Mummy") },
            { PBEAbility.NaturalCure, new PBELocalizedString("しぜんかいふく", "자연회복", "Médic Nature", "Innere Kraft", "Cura Natural", "Alternacura", "Natural Cure") },
            { PBEAbility.NoGuard, new PBELocalizedString("ノーガード", "노가드", "Annule Garde", "Schildlos", "Indefenso", "Nullodifesa", "No Guard") },
            { PBEAbility.Normalize, new PBELocalizedString("ノーマルスキン", "노말스킨", "Normalise", "Regulierung", "Normalidad", "Normalità", "Normalize") },
            { PBEAbility.Oblivious, new PBELocalizedString("どんかん", "둔감", "Benêt", "Dösigkeit", "Despiste", "Indifferenza", "Oblivious") },
            { PBEAbility.Overcoat, new PBELocalizedString("ぼうじん", "방진", "Envelocape", "Wetterfest", "Funda", "Copricapo", "Overcoat") },
            { PBEAbility.Overgrow, new PBELocalizedString("しんりょく", "심록", "Engrais", "Notdünger", "Espesura", "Erbaiuto", "Overgrow") },
            { PBEAbility.OwnTempo, new PBELocalizedString("マイペース", "마이페이스", "Tempo Perso", "Tempomacher", "Ritmo Propio", "Mente Locale", "Own Tempo") },
            { PBEAbility.Pickpocket, new PBELocalizedString("わるいてぐせ", "나쁜손버릇", "Pickpocket", "Langfinger", "Hurto", "Arraffalesto", "Pickpocket") },
            { PBEAbility.Pickup, new PBELocalizedString("ものひろい", "픽업", "Ramassage", "Mitnahme", "Recogida", "Raccolta", "Pickup") },
            { PBEAbility.Plus, new PBELocalizedString("プラス", "플러스", "Plus", "Plus", "Más", "Più", "Plus") },
            { PBEAbility.PoisonHeal, new PBELocalizedString("ポイズンヒール", "포이즌힐", "Soin Poison", "Aufheber", "Antídoto", "Velencura", "Poison Heal") },
            { PBEAbility.PoisonPoint, new PBELocalizedString("どくのトゲ", "독가시", "Point Poison", "Giftdorn", "Punto Tóxico", "Velenopunto", "Poison Point") },
            { PBEAbility.PoisonTouch, new PBELocalizedString("どくしゅ", "독수", "Toxitouche", "Giftgriff", "Toque Tóxico", "Velentocco", "Poison Touch") },
            { PBEAbility.Prankster, new PBELocalizedString("いたずらごころ", "짓궂은마음", "Farceur", "Strolch", "Bromista", "Burla", "Prankster") },
            { PBEAbility.Pressure, new PBELocalizedString("プレッシャー", "프레셔", "Pression", "Erzwinger", "Presión", "Pressione", "Pressure") },
            { PBEAbility.PurePower, new PBELocalizedString("ヨガパワー", "순수한힘", "Force Pure", "Mentalkraft", "Energía Pura", "Forzapura", "Pure Power") },
            { PBEAbility.QuickFeet, new PBELocalizedString("はやあし", "속보", "Pied Véloce", "Rasanz", "Pies Rápidos", "Piedisvelti", "Quick Feet") },
            { PBEAbility.RainDish, new PBELocalizedString("あめうけざら", "젖은접시", "Cuvette", "Regengenuss", "Cura Lluvia", "Copripioggia", "Rain Dish") },
            { PBEAbility.Rattled, new PBELocalizedString("びびり", "주눅", "Phobique", "Hasenfuß", "Cobardía", "Paura", "Rattled") },
            { PBEAbility.Reckless, new PBELocalizedString("すてみ", "이판사판", "Téméraire", "Achtlos", "Audaz", "Temerarietà", "Reckless") },
            { PBEAbility.Regenerator, new PBELocalizedString("さいせいりょく", "재생력", "Régé-Force", "Belebekraft", "Regeneración", "Rigenergia", "Regenerator") },
            { PBEAbility.Rivalry, new PBELocalizedString("とうそうしん", "투쟁심", "Rivalité", "Rivalität", "Rivalidad", "Antagonismo", "Rivalry") },
            { PBEAbility.RockHead, new PBELocalizedString("いしあたま", "돌머리", "Tête de Roc", "Steinhaupt", "Cabeza Roca", "Testadura", "Rock Head") },
            { PBEAbility.RoughSkin, new PBELocalizedString("さめはだ", "까칠한피부", "Peau Dure", "Rauhaut", "Piel Tosca", "Cartavetro", "Rough Skin") },
            { PBEAbility.RunAway, new PBELocalizedString("にげあし", "도주", "Fuite", "Angsthase", "Fuga", "Fugafacile", "Run Away") },
            { PBEAbility.SandForce, new PBELocalizedString("すなのちから", "모래의힘", "Force Sable", "Sandgewalt", "Poder Arena", "Silicoforza", "Sand Force") },
            { PBEAbility.SandRush, new PBELocalizedString("すなかき", "모래헤치기", "Baigne Sable", "Sandscharrer", "Ímpetu Arena", "Remasabbia", "Sand Rush") },
            { PBEAbility.SandStream, new PBELocalizedString("すなおこし", "모래날림", "Sable Volant", "Sandsturm", "Chorro Arena", "Sabbiafiume", "Sand Stream") },
            { PBEAbility.SandVeil, new PBELocalizedString("すながくれ", "모래숨기", "Voile Sable", "Sandschleier", "Velo Arena", "Sabbiavelo", "Sand Veil") },
            { PBEAbility.SapSipper, new PBELocalizedString("そうしょく", "초식", "Herbivore", "Vegetarier", "Herbívoro", "Mangiaerba", "Sap Sipper") },
            { PBEAbility.Scrappy, new PBELocalizedString("きもったま", "배짱", "Querelleur", "Rauflust", "Intrépido", "Nervisaldi", "Scrappy") },
            { PBEAbility.SereneGrace, new PBELocalizedString("てんのめぐみ", "하늘의은총", "Sérénité", "Edelmut", "Dicha", "Leggiadro", "Serene Grace") },
            { PBEAbility.ShadowTag, new PBELocalizedString("かげふみ", "그림자밟기", "Marque Ombre", "Wegsperre", "Sombratrampa", "Pedinombra", "Shadow Tag") },
            { PBEAbility.ShedSkin, new PBELocalizedString("だっぴ", "탈피", "Mue", "Expidermis", "Mudar", "Muta", "Shed Skin") },
            { PBEAbility.SheerForce, new PBELocalizedString("ちからずく", "우격다짐", "Sans Limite", "Rohe Gewalt", "Pot. Bruta", "Forzabruta", "Sheer Force") },
            { PBEAbility.ShellArmor, new PBELocalizedString("シェルアーマー", "조가비갑옷", "Coque Armure", "Panzerhaut", "Caparazón", "Guscioscudo", "Shell Armor") },
            { PBEAbility.ShieldDust, new PBELocalizedString("りんぷん", "인분", "Écran Poudre", "Puderabwehr", "Polvo Escudo", "Polvoscudo", "Shield Dust") },
            { PBEAbility.Simple, new PBELocalizedString("たんじゅん", "단순", "Simple", "Wankelmut", "Simple", "Disinvoltura", "Simple") },
            { PBEAbility.SkillLink, new PBELocalizedString("スキルリンク", "스킬링크", "Multi-Coups", "Wertelink", "Encadenado", "Abillegame", "Skill Link") },
            { PBEAbility.SlowStart, new PBELocalizedString("スロースタート", "슬로스타트", "Début Calme", "Saumselig", "Inicio Lento", "Lentoinizio", "Slow Start") },
            { PBEAbility.Sniper, new PBELocalizedString("スナイパー", "스나이퍼", "Sniper", "Superschütze", "Francotirad.", "Cecchino", "Sniper") },
            { PBEAbility.SnowCloak, new PBELocalizedString("ゆきがくれ", "눈숨기", "Rideau Neige", "Schneemantel", "Manto Níveo", "Mantelneve", "Snow Cloak") },
            { PBEAbility.SnowWarning, new PBELocalizedString("ゆきふらし", "눈퍼뜨리기", "Alerte Neige", "Hagelalarm", "Nevada", "Scendineve", "Snow Warning") },
            { PBEAbility.SolarPower, new PBELocalizedString("サンパワー", "선파워", "Force Soleil", "Solarkraft", "Poder Solar", "Solarpotere", "Solar Power") },
            { PBEAbility.SolidRock, new PBELocalizedString("ハードロック", "하드록", "Solide Roc", "Felskern", "Roca Sólida", "Solidroccia", "Solid Rock") },
            { PBEAbility.Soundproof, new PBELocalizedString("ぼうおん", "방음", "Anti-Bruit", "Lärmschutz", "Insonorizar", "Antisuono", "Soundproof") },
            { PBEAbility.SpeedBoost, new PBELocalizedString("かそく", "가속", "Turbo", "Temposchub", "Impulso", "Acceleratore", "Speed Boost") },
            { PBEAbility.Stall, new PBELocalizedString("あとだし", "시간벌기", "Frein", "Zeitspiel", "Rezagado", "Rallentatore", "Stall") },
            { PBEAbility.Static, new PBELocalizedString("せいでんき", "정전기", "Statik", "Statik", "Elec. Estát.", "Statico", "Static") },
            { PBEAbility.Steadfast, new PBELocalizedString("ふくつのこころ", "불굴의마음", "Impassible", "Felsenfest", "Impasible", "Cuordeciso", "Steadfast") },
            { PBEAbility.Stench, new PBELocalizedString("あくしゅう", "악취", "Puanteur", "Duftnote", "Hedor", "Tanfo", "Stench") },
            { PBEAbility.StickyHold, new PBELocalizedString("ねんちゃく", "점착", "Glue", "Wertehalter", "Viscosidad", "Antifurto", "Sticky Hold") },
            { PBEAbility.StormDrain, new PBELocalizedString("よびみず", "마중물", "Lavabo", "Sturmsog", "Colector", "Acquascolo", "Storm Drain") },
            { PBEAbility.Sturdy, new PBELocalizedString("がんじょう", "옹골참", "Fermeté", "Robustheit", "Robustez", "Vigore", "Sturdy") },
            { PBEAbility.SuctionCups, new PBELocalizedString("きゅうばん", "흡반", "Ventouse", "Saugnapf", "Ventosas", "Ventose", "Suction Cups") },
            { PBEAbility.SuperLuck, new PBELocalizedString("きょううん", "대운", "Chanceux", "Glückspilz", "Afortunado", "Supersorte", "Super Luck") },
            { PBEAbility.Swarm, new PBELocalizedString("むしのしらせ", "벌레의알림", "Essaim", "Hexaplaga", "Enjambre", "Aiutinsetto", "Swarm") },
            { PBEAbility.SwiftSwim, new PBELocalizedString("すいすい", "쓱쓱", "Glissade", "Wassertempo", "Nado Rápido", "Nuotovelox", "Swift Swim") },
            { PBEAbility.Synchronize, new PBELocalizedString("シンクロ", "싱크로", "Synchro", "Synchro", "Sincronía", "Sincronismo", "Synchronize") },
            { PBEAbility.TangledFeet, new PBELocalizedString("ちどりあし", "갈지자걸음", "Pieds Confus", "Fußangel", "Tumbos", "Intricopiedi", "Tangled Feet") },
            { PBEAbility.Technician, new PBELocalizedString("テクニシャン", "테크니션", "Technicien", "Techniker", "Experto", "Tecnico", "Technician") },
            { PBEAbility.Telepathy, new PBELocalizedString("テレパシー", "텔레파시", "Télépathe", "Telepathie", "Telepatía", "Telepatia", "Telepathy") },
            { PBEAbility.Teravolt, new PBELocalizedString("テラボルテージ", "테라볼티지", "Téra-Voltage", "Teravolt", "Terravoltaje", "Teravolt", "Teravolt") },
            { PBEAbility.ThickFat, new PBELocalizedString("あついしぼう", "두꺼운지방", "Isograisse", "Speckschicht", "Sebo", "Grassospesso", "Thick Fat") },
            { PBEAbility.TintedLens, new PBELocalizedString("いろめがね", "색안경", "Lentiteintée", "Aufwertung", "Cromolente", "Lentifumé", "Tinted Lens") },
            { PBEAbility.Torrent, new PBELocalizedString("げきりゅう", "급류", "Torrent", "Sturzbach", "Torrente", "Acquaiuto", "Torrent") },
            { PBEAbility.ToxicBoost, new PBELocalizedString("どくぼうそう", "독폭주", "Rage Poison", "Giftwahn", "Ím. Tóxico", "Velenimpeto", "Toxic Boost") },
            { PBEAbility.Trace, new PBELocalizedString("トレース", "트레이스", "Calque", "Fährte", "Rastro", "Traccia", "Trace") },
            { PBEAbility.Truant, new PBELocalizedString("なまけ", "게으름", "Absentéisme", "Schnarchnase", "Ausente", "Pigrone", "Truant") },
            { PBEAbility.Turboblaze, new PBELocalizedString("ターボブレイズ", "터보블레이즈", "TurboBrasier", "Turbobrand", "Turbollama", "Piroturbina", "Turboblaze") },
            { PBEAbility.Unaware, new PBELocalizedString("てんねん", "천진", "Inconscient", "Unkenntnis", "Ignorante", "Imprudenza", "Unaware") },
            { PBEAbility.Unburden, new PBELocalizedString("かるわざ", "곡예", "Délestage", "Entlastung", "Liviano", "Agiltecnica", "Unburden") },
            { PBEAbility.Unnerve, new PBELocalizedString("きんちょうかん", "긴장감", "Tension", "Anspannung", "Nerviosismo", "Agitazione", "Unnerve") },
            { PBEAbility.VictoryStar, new PBELocalizedString("しょうりのほし", "승리의별", "Victorieux", "Triumphstern", "Tinovictoria", "Vittorstella", "Victory Star") },
            { PBEAbility.VitalSpirit, new PBELocalizedString("やるき", "의기양양", "Esprit Vital", "Munterkeit", "Espír. Vital", "Spiritovivo", "Vital Spirit") },
            { PBEAbility.VoltAbsorb, new PBELocalizedString("ちくでん", "축전", "Absorb Volt", "Voltabsorber", "Absor. Elec.", "Assorbivolt", "Volt Absorb") },
            { PBEAbility.WaterAbsorb, new PBELocalizedString("ちょすい", "저수", "Absorb Eau", "H2O-Absorber", "Absor. Agua", "Assorbacqua", "Water Absorb") },
            { PBEAbility.WaterVeil, new PBELocalizedString("みずのベール", "수의베일", "Ignifu-Voile", "Aquahülle", "Velo Agua", "Idrovelo", "Water Veil") },
            { PBEAbility.WeakArmor, new PBELocalizedString("くだけるよろい", "깨어진갑옷", "Armurouillée", "Bruchrüstung", "Arm. Frágil", "Sottilguscio", "Weak Armor") },
            { PBEAbility.WhiteSmoke, new PBELocalizedString("しろいけむり", "하얀연기", "Écran Fumée", "Pulverrauch", "Humo Blanco", "Fumochiaro", "White Smoke") },
            { PBEAbility.WonderGuard, new PBELocalizedString("ふしぎなまもり", "불가사의부적", "Garde Mystik", "Wunderwache", "Superguarda", "Magidifesa", "Wonder Guard") },
            { PBEAbility.WonderSkin, new PBELocalizedString("ミラクルスキン", "미라클스킨", "Peau Miracle", "Wunderhaut", "Piel Milagro", "Splendicute", "Wonder Skin") },
            { PBEAbility.ZenMode, new PBELocalizedString("ダルマモード", "달마모드", "Mode Transe", "Trance-Modus", "Modo Daruma", "Stato Zen", "Zen Mode") }
        });
    }
}