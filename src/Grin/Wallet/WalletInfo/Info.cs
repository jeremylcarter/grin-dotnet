using Grin.Wallet.Types;

namespace Grin.Wallet.Info
{
    public class Info
    {

    public void show_info(WalletConfig config, Keychain.KeychainImpl.Keychain keychain)
        {
       Checker.Checker.refresh_outputs(config, keychain);


  //     WalletData.read_wallet(config.data_file_dir, wallet_data =>
  //     {
  //         var current_height = Checker.Checker.get_tip_from_node(config);
           
           
  //         {
  //                  Ok(tip) => tip.height,
		//	Err(_) => match wallet_data.outputs.values().map(|out| out.height).max() {
  //                      Some(height) => height,
		//		None => 0,
		//	},
		//};
  //              let mut unspent_total = 0;
  //              let mut unspent_but_locked_total = 0;
  //              let mut unconfirmed_total = 0;
  //              let mut locked_total = 0;
  //              for out in wallet_data
  //                  .outputs
  //                  .values()
  //                  .filter(|out| out.root_key_id == keychain.root_key_id())
        
  //      {
  //                  if out.status == OutputStatus::Unspent {
  //                      unspent_total +=out.value;
  //                      if out.lock_height > current_height {
  //                          unspent_but_locked_total +=out.value;
  //                      }
  //                  }
  //                  if out.status == OutputStatus::Unconfirmed && !out.is_coinbase {
  //                      unconfirmed_total +=out.value;
  //                  }
  //                  if out.status == OutputStatus::Locked {
  //                      locked_total +=out.value;
  //                  }
  //              };


  //              println!();
  //              let title = format!("Wallet Summary Info - Block Height: {}", current_height);
  //              let mut t = term::stdout().unwrap();
  //              t.fg(term::color::MAGENTA).unwrap();
  //              writeln!(t, "{}", title).unwrap();
  //              writeln!(t, "--------------------------").unwrap();
  //              t.reset().unwrap();

  //              let mut table = table!(
        
  //                  [bFG->"Total", FG->amount_to_hr_string(unspent_total + unconfirmed_total)],
        
  //                  [bFY->"Awaiting Confirmation", FY->amount_to_hr_string(unconfirmed_total)],
        
  //                  [bFY->"Confirmed but Still Locked", FY->amount_to_hr_string(unspent_but_locked_total)],
        
  //                  [bFG->"Currently Spendable", FG->amount_to_hr_string(unspent_total - unspent_but_locked_total)],
        
  //                  [Fw->"---------", Fw->"---------"],
        
  //                  [Fr->"(Locked by previous transaction)", Fr->amount_to_hr_string(locked_total)]
  //              );
  //              table.set_format(*prettytable::format::consts::FORMAT_NO_BORDER_LINE_SEPARATOR);
  //              table.printstd();
  //              println!();
  //          });

  //          if let Err(_) = result {
  //              println!("WARNING - Showing local data only - Wallet was unable to contact a node to update and verify the info shown here.");
  //          }
        }


    }
}